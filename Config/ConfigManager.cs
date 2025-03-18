using System;
using System.IO;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Icr_Treasury_Control.Classes;
public class ConfigManager
{
    public string ChuDenoFed { get; set; } // Church Denomination Federation
    public string ChurchName { get; set; }
    public string Color { get; set; }
    public string ImagePath { get; set; }

    public long Perso_ID { get; set; }

    private string cs => Path.Combine(new DataRec().FolderPath, "-Configurações");

    public string SaveImage(Image image)
    {
        // Define the maximum width
        int maxLength = 150;

        // Create a copy of the original image for comparison
        Image originalImage = (Image)image.Clone();

        // Check if the image width is greater than the maximum width
        if (image.Width > maxLength)
        {
            // Calculate proportional height
            float ratio = (float)maxLength / image.Width;
            int newHeight = (int)(image.Height * ratio);

            // Create a new resized image
            using (Image resizedImage = new Bitmap(image, new Size(maxLength, newHeight)))
            {
                image = (Image)resizedImage.Clone(); // Create a copy of the resized image
            } // The resizedImage is discarded here
        }

        // Generate the image path
        string imageName = "logo" + ".png";
        string imagePath = Path.Combine(cs, imageName);

        // Check if the image already exists in the directory and calculate its hash
        if (File.Exists(imagePath))
        {
            // Load the existing image from the path
            using (Image existingImage = Image.FromFile(imagePath))
            {
                // Calculate the hash of the existing image
                string existingImageHash = CalculateImageHash(existingImage);

                // Calculate the hash of the new image
                string newImageHash = CalculateImageHash(image);

                // If the hashes are equal, the image has not changed, so do not save it
                if (existingImageHash == newImageHash)
                {
                    return imagePath;
                }
            }

            // Delete the existing file if the hashes are different
            File.Delete(imagePath);
        }

        try
        {
            // Check if the directory exists, if not, create it
            string directory = Path.GetDirectoryName(imagePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Save the new image as PNG
            image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);

            // Release image resources
            image.Dispose(); // Free image resources after saving
        }
        catch (UnauthorizedAccessException ex)
        {
            MessageBox.Show("Erro de Permissão: " + ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            MessageBox.Show("Error: Pasta não Encontrada " + ex.Message);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error ao salvar a imagem: " + ex.Message);
        }

        // Return the image path
        return imagePath;
    }

    private string CalculateImageHash(Image image)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            // Save the image in a MemoryStream to calculate the hash
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imageBytes = ms.ToArray();

            // Compute the MD5 hash of the image
            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(imageBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }

    public void SaveConfigurations(string imagePath, Color selectedColor, string churchText, string chuDenoText, string personalID)
    {
        var configurations = new
        {
            Image = imagePath,
            Color = selectedColor.ToArgb(),
            ChurchName = churchText,
            ChuDenoFed = chuDenoText,
            PersoID = personalID,
        };

        // Configuration file path
        string configPath = Path.Combine(cs, "Config.json");

        // Check if the directory exists, if not, create it
        string directory = Path.GetDirectoryName(configPath);
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        // Serialize the configurations into JSON and save to file
        File.WriteAllText(configPath, JsonConvert.SerializeObject(configurations, Formatting.Indented));
    }

    public dynamic LoadConfigurations()
    {
        string configPath = Path.Combine(cs, "Config.json");

        if (File.Exists(configPath))
        {
            // Read the JSON file and deserialize the configurations
            string json = File.ReadAllText(configPath);
            return JsonConvert.DeserializeObject(json);
        }

        return null;
    }
}
