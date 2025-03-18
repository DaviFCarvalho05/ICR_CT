using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Icr_Treasury_Control.Classes;

internal class DynamicSizes
{
    private readonly Dictionary<Control, (int Width, int Height, int Left, int Top)> _originalSizes = new();
    private Size _originalFormSize;

    public void SaveOriginalSizes(Control parent, Form form)
    {
        if(_originalSizes.Count == 0)
        {
            _originalFormSize = form.ClientSize;

            foreach (Control control in parent.Controls)
            {
                SaveControlOriginalSizes(control);
            } 
        }
    }

    private void SaveControlOriginalSizes(Control control)
    {
         if (!_originalSizes.ContainsKey(control))
            {
                _originalSizes[control] = (control.Width, control.Height, control.Left, control.Top);
            }

            foreach (Control child in control.Controls)
            {
                SaveControlOriginalSizes(child);
            }
    }

    public void ResizeAll(Control parent, Form form)
    {
        if (_originalSizes.Count == 0)
            return;

        //Calculate scale ratios 
        float W_Ratio = (float)(form.ClientSize.Width / _originalFormSize.Width);
        float H_Ratio = (float)(form.ClientSize.Height / _originalFormSize.Height);

        foreach (Control control in parent.Controls) 
        {
            ResizeControl(control, W_Ratio, H_Ratio);
        }
    }

    private void ResizeControl(Control control ,float W_Ratio,float H_Ratio)
    {
        if (!_originalSizes.ContainsKey(control)) return;

        var (originalWidth, originalHeight, originalLeft, originalTop) = _originalSizes[control];

        // Ajustar tamanho e posição do controle
        control.Width = (int)(originalWidth * W_Ratio);
        control.Height = (int)(originalHeight * H_Ratio);
        control.Left = (int)(originalLeft * W_Ratio);
        control.Top = (int)(originalTop * H_Ratio);

        foreach (Control child in control.Controls) 
        {
            ResizeControl(child, W_Ratio, H_Ratio);
        }
    }
}
