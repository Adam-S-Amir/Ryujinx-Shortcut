using System;
using System.Diagnostics;
using System.IO;

namespace Launch_Anything_With_C_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string ryujinxPath = Path.Combine("..", "_Ryujinx", "ryujinx.exe");
            string nspFilePath = Path.Combine("..", "Game", "GameID.nsp");

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = ryujinxPath,
                Arguments = $"\"{nspFilePath}\"",
                WorkingDirectory = Path.GetDirectoryName(ryujinxPath)
            };

            new Process { StartInfo = startInfo }.Start();
        }
    }
}
