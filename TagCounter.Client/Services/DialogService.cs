using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace TagCounter.Client.Services
{
    public class DialogService : IDialogService
    {
        public string FilePath { get; set; }

        public bool OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() 
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "JSON files (*.json) | *.json"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                return true;
            }
            return false;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
