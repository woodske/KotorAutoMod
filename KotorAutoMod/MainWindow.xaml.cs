using Ookii.Dialogs.Wpf;
using System;
using System.Windows;
using System.IO.Compression;

namespace KotorAutoMod
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string folderPath = "";

        private void unzipFiles()
        {
            Console.Write(Path.)
            ZipFile.ExtractToDirectory("Remove Duplicate TGA-TPC-1127-1-2-1616219725.zip", folderPath);
        }

        private void SelectSwkotorFolderButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new VistaFolderBrowserDialog();
            dialog.Description = "Please select the swkotor folder.";
            dialog.UseDescriptionForTitle = true;

            if ((bool)dialog.ShowDialog(this))
            {
                MessageBox.Show(this, $"The selected folder was:{Environment.NewLine}{dialog.SelectedPath}", "Sample folder browser dialog");
                folderPath = dialog.SelectedPath;
            }
            unzipFiles();
        }
    }
}
