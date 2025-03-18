using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json;
using Icr_Treasury_Control.Classes;

namespace Icr_Treasury_Control.Dashboard
{
    internal class Dashboard_Funcs
    {
        DataRec r = new DataRec();
        public double Total(string Class, string pdp)
        {
            double total = 0;
            //Construct the path to the target folder 
            string tF = Path.Combine(r.FolderPath, pdp, Class);

            //Check if the folder exists
            if (!Directory.Exists(tF))
                return 0;

            //Get all JSON files in the folder
            string[] files = Directory.GetFiles(tF, "*.json");
            if (files == null)
                return 0;

            foreach (var file in files)
            {
                try
                {

                    //Read the content of the JSON file
                    string JContent = File.ReadAllText(file);

                    //Deserialize the object
                    var dtObject = JsonConvert.DeserializeObject<DataRec>(JContent);

                    //Add the DataValue to the total sum
                    if (dtObject != null)
                    {
                        total += dtObject.DataValue;
                    }
                }
                catch (Exception ex)
                {
                    ex = null;
                    return 0;
                }
            }

            return total;
        }

        public int File_Total(string pdp, string Class)
        {
            string ft = Path.Combine(r.FolderPath, pdp, Class);
            int total = Directory.GetFiles(ft).Length;
            return total;
        }
        public int CtDtT(string pdp, string Class, string dtype)
        {
            int count = 0;

            //Construct the path to the target folder 
            string tF = Path.Combine(r.FolderPath, pdp, Class);

            //Check if the folder exists
            if (!Directory.Exists(tF))
                return 0;

            //Get all JSON files in the folde
            string[] files = Directory.GetFiles(tF, "*.json");
            foreach (var file in files)
            {
                try
                {
                    //Read the content of the JSON file
                    string JContent = File.ReadAllText(file);

                    //Deserialize the object
                    var dataObject = JsonConvert.DeserializeObject<DataRec>(JContent);

                    //Chec if Datatype matches the parameter
                    if (dataObject != null && dataObject.DataType == dtype)
                        count++;

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());
                }
            }
            return count;
        }
        public int Percentual(string pdp, string dtype, double value, string dclass)
        {
            int ExPerc = 0;
            double count = 0;

            //Construct the path to the target folder 
            string tF = Path.Combine(r.FolderPath, pdp, dclass);

            //Check if the folder exists
            if (!Directory.Exists(tF))
                return 0;

            //Get all JSON files in the folde
            string[] files = Directory.GetFiles(tF, "*.json");
            foreach (var file in files)
            {
                try
                {
                    //Read the content of the JSON file
                    string JContent = File.ReadAllText(file);

                    //Deserialize the object
                    var dataObject = JsonConvert.DeserializeObject<DataRec>(JContent);

                    //Chec if Datatype matches the parameter
                    if (dataObject != null && dataObject.DataType == dtype)
                        count += dataObject.DataValue;

                    
                        


                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());
                }
            }
            double calculo = ((double)count / value) * 100;
            ExPerc = (int)Math.Round(calculo);
            return ExPerc;
        }
        
    }
}
