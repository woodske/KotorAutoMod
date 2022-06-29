using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class Four_GB_Patch_Instructions : IInstructions
    {
        public Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move the executable to swkotor folder. Add instructions to run the executable and point it towards your swkotor.exe
            modConfig.Instructions = $"Run the 4gb_patch.exe in your swkotor folder.\n" +
                "Point the 4GB patch application to your swkotor.exe\n" +
                $"{Path.Combine(modConfig.SwkotorDirectory, "swkotor.exe")}";

            string fourGbPatchExecutableStart = Path.Combine(readyMods[0], "4gb_patch.exe");
            string fourGbPatchExecutableEnd = Path.Combine(modConfig.SwkotorDirectory, "4gb_patch.exe");

            File.Copy(fourGbPatchExecutableStart, fourGbPatchExecutableEnd, true);
            Process.Start("explorer.exe", modConfig.SwkotorDirectory);

            MessageBox.Show("Follow the instructions in the instructions box then press OK when done",
                "KOTOR High Resolution Menus",
                MessageBoxButton.OK
                );

            return Task.CompletedTask;
            //await Utils.runExecutable(fourGbPatchExecutable);
        }
    }
}
