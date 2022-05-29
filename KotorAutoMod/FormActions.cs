using Ookii.Dialogs.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KotorAutoMod
{
    internal class FormActions
    {
        public ModConfig modConfig;
        
        public FormActions(ModConfig config)
        {
            modConfig = config;
        }

        public void HandleSwkotorFolderSelect(Window window)
        {
            var dialog = new VistaFolderBrowserDialog();
            dialog.Description = "Please select the swkotor folder.";
            dialog.UseDescriptionForTitle = true;      

            if ((bool)dialog.ShowDialog(window))
            {
                MessageBox.Show(window, $"The selected folder was:{Environment.NewLine}{dialog.SelectedPath}");
                modConfig.swkotorFilePath = dialog.SelectedPath;
            }

            System.Diagnostics.Debug.WriteLine(modConfig.swkotorFilePath);
        }
    }
}
