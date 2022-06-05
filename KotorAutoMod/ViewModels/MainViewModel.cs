using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading;
using System.Windows.Threading;

namespace KotorAutoMod.ViewModels
{
    public class MainViewModel
    {
        public TextBlockViewModel TextBlock { get; private set; }

        public ModListViewModel ModList { get; private set; }

        public ComboBoxViewModel ComboBox { get; private set; }

        public ProgressBarViewModel ProgressBar { get; private set; }

        public MainViewModel()
        {
            TextBlock = new TextBlockViewModel();
            ModList = new ModListViewModel();
            ComboBox = new ComboBoxViewModel();
            ProgressBar = new ProgressBarViewModel();
        }

        public void SetInstructions(string instructions)
        {
            TextBlock.Instructions = instructions;
        }

        public void SetAvailableModsList(ObservableCollection<Mod> modList)
        {
            ModList.AvailableModsList = modList;
        }

        public void SetUnavailableModsList(List<Mod> modList)
        {
            ModList.UnavailableModsList = modList;
        }

        public void SetDescription(Mod mod)
        {
            TextBlock.Description = mod;
        }

        public void SetValidAspectRatios(string[] validAspectRatios)
        {
            ComboBox.ValidAspectRatios = validAspectRatios;
        }

        public void SetValidScreenResolutions(string[] validScreenResolutions)
        {
            ComboBox.ValidScreenResolutions = validScreenResolutions;
        }

        public void SetShowValidAspectRatios(bool showValidAspectRatios)
        {
            if (!showValidAspectRatios)
            {
                ComboBox.ShowValidAspectRatios = "Hidden";
            }
            else
            {
                ComboBox.ShowValidAspectRatios = "Visible";
            }
        }

        public void SetShowValidScreenResolutions(bool showValidScreenResolutions)
        {
            if (!showValidScreenResolutions)
            {
                ComboBox.ShowValidScreenResolutions = "Hidden";
            }
            else
            {
                ComboBox.ShowValidScreenResolutions = "Visible";
            }
        }

        public void SetProgressBarMaximum(int maximum)
        {
            ProgressBar.Maximum = maximum;
        }

        public void IterateProgressBarValue(string text)
        {
            ProgressBar.Value++;
            SetProgressText(text);
        }

        public void SetProgressValue(int value)
        {
            ProgressBar.Value = value;
        }

        public void SetProgressText(string text)
        {
            ProgressBar.Text = text;
        }
    }
}
