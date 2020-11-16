using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project_4._0
{
    public  class FileManager
    {
        private static Bitmap MyImage;

        

        public static void ShowMyImage(String fileToDisplay, PictureBox pictureBox2, int xSize, int ySize)
        {
            // Sets up an image object to be displayed.
            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(fileToDisplay);
            pictureBox2.ClientSize = new Size(xSize, ySize);
            pictureBox2.Image = (Image)MyImage;
        }

         public static string GetLogs(string path)
        {

            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException();
            }
        
            string logs = default;
            if (File.Exists(path))
            {
                logs = File.ReadAllText(path);
            }
            return logs;
        }

        public static void WriteLogs(string path, string userEmail, LogStatus logStatus)
        {
            IFormatter formatter = new MyFormatter(userEmail, logStatus);
            if (File.Exists(path))
            {
                File.AppendAllText(path, GetLogInfo(formatter));
            }
            else
            {
                File.WriteAllText(path, GetLogInfo(formatter));
            }
        }

        public static string GetPath(string folder, string fileName)
        {
            DirectoryInfo directoryInfo = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString());
            string path = $"{directoryInfo}/{folder}/{fileName}";
            return path;
        }

       private static string GetLogInfo(IFormatter formatter)
        {
            return formatter.Format();
        }
    }
}
