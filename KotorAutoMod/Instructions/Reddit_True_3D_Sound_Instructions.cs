using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_True_3D_Sound_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            //Extract the file. Move everything but the two .zip archives and the two readme files directly to your game folder (NOT the override directory).
            //Then untick the "Allow applications to take exclusive control of this device" setting on your speakers (in Windows 10, you can find this by right-clicking your speakers in your taskbar, opening your sound settings,
            //clicking on your speaker's device properties, selecting "additional device properties," and then going to the Advanced tab).
            modConfig.Instructions =
                "Moving files to swkotor folder.\n\n" +
                "Untick the \"Allow applications to take exclusive control of this device\" setting on your speakers (in Windows 10, you can find this by right-clicking your speakers in your taskbar, opening your sound settings clicking on your speaker's device properties, selecting \"additional device properties,\" and then going to the Advanced tab).";
            await Task.Run(() => File.Copy(Path.Combine(readyMods[0], "alsoft.ini"), Path.Combine(modConfig.SwkotorDirectory, "alsoft.ini"), true));
            await Task.Run(() => File.Copy(Path.Combine(readyMods[0], "dsoal_log_error.bat"), Path.Combine(modConfig.SwkotorDirectory, "dsoal_log_error.bat"), true));
            await Task.Run(() => File.Copy(Path.Combine(readyMods[0], "dsoal-aldrv.dll"), Path.Combine(modConfig.SwkotorDirectory, "dsoal-aldrv.dll"), true));
            await Task.Run(() => File.Copy(Path.Combine(readyMods[0], "dsound.dll"), Path.Combine(modConfig.SwkotorDirectory, "dsound.dll"), true));
            MessageBox.Show("Follow the instructions to enable 3D sound then click OK when done.", "3D Sound Instructions", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
