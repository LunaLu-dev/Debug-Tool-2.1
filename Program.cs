using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;

namespace Debug_Tool_2._1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static readonly Stopwatch Timer = new Stopwatch();
        [STAThread]
        static void Main()
        {

            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            bool sfcC = false;
            bool dismC = false;
            bool copyC = false;
            bool pasteC = false;

            Form myform = new Form()
            {
                Height = 500,
                Width = 400,
            };


            //WINGET
            bool chromeIns = false;
            bool firefoxIns = false;
            bool operaIns = false;
            bool steamIns = false;
            bool discordIns = false;
            bool updateIns = false;


            Label winGetL = new Label()
            {
                Height = 25,
                Width = 500,
                Text = "Chose What you want to install",
                Location = new Point(120, 10),
                Visible = false
            };
            //Web Browsers
            Button chrome = new Button()
            {
                Height = 25,
                Width = 120,
                Text = "Google Chrome",
                Location = new Point(20, 40),
                Visible = false
            };
            chrome.Click += (o, s) => {
                if (chromeIns == false)
                {
                    chromeIns = true;
                    chrome.Text = "Google Chrome ✓";
                }
                else if (chromeIns)
                {
                    chromeIns = false;
                    chrome.Text = "Google Chrome";
                }
            };

            Button firefox = new Button()
            {
                Height = 25,
                Width = 120,
                Text = "Firefox",
                Location = new Point(20, 70),
                Visible = false
            };
            firefox.Click += (o, s) => {
                if (firefoxIns == false)
                {
                    firefoxIns = true;
                    firefox.Text = "Firefox ✓"; 
                }
                else if (firefoxIns)
                {
                    firefoxIns = false;
                    firefox.Text = "Firefox";
                }
            };

            Button opera = new Button()
            {
                Height = 25,
                Width = 120,
                Text = "Opera",
                Location = new Point(20, 100),
                Visible = false
            };
            opera.Click += (o, s) => {
                if (operaIns == false)
                {
                    operaIns = true;
                    opera.Text = "Opera ✓";
                }
                else if (operaIns)
                {
                    operaIns = false;
                    opera.Text = "Opera";
                }
            };
            //Software
            Button steam = new Button()
            {
                Height = 25,
                Width = 120,
                Text = "Steam",
                Location = new Point(20, 150),
                Visible = false
            };
            steam.Click += (o, s) => {
                if (steamIns == false)
                {
                    steamIns = true;
                    steam.Text = "Steam ✓";
                }
                else if (steamIns)
                {
                    steamIns = false;
                    steam.Text = "Steam";
                }
            };
            Button discord = new Button()
            {
                Height = 25,
                Width = 120,
                Text = "Discord",
                Location = new Point(20, 180),
                Visible = false
            };
            discord.Click += (o, s) => {
                if (discordIns == false)
                {
                    discordIns = true;
                    discord.Text = "Discord ✓";
                }
                else if (discordIns)
                {
                    discordIns = false;
                    discord.Text = "Discord";
                }
            };

            //Command
            Button update = new Button()
            {
                Height = 25,
                Width = 120,
                Text = "Update /all",
                Location = new Point(20, 230),
                Visible = false
            };
            update.Click += (o, s) => {
                if (updateIns == false)
                {
                    updateIns = true;
                    update.Text = "Update /all ✓";
                }
                else if (updateIns)
                {
                    updateIns = false;
                    update.Text = "Update /all";
                }
            };
            Button winGetBack = new Button()
            {
                Height = 50,
                Width = 100,
                Text = "Confirm",
                Visible = false,
                Location = new Point(10, 300)
            };


            //DEBUG
            Button sfc = new Button()
            {
                Height = 100,
                Width = 100,
                Text = "SFC",
                Location = new Point(10, 10)
            };
            sfc.Click += (o, s) => {
                if (sfcC == false)
                {
                    sfcC = true;
                    sfc.Text = "SFC ✓";
                }
                else if (sfcC)
                {
                    sfcC = false;
                    sfc.Text = "SFC";
                }
            };

            Button dism = new Button()
            {
                Height = 100,
                Width = 100,
                Text = "DISM",
                Location = new Point(120, 10)
            };
            dism.Click += (o, s) => {
                if (dismC == false)
                {
                    dismC = true;
                    dism.Text = "DISM ✓";
                }
                else if (dismC)
                {
                    dismC = false;
                    dism.Text = "DISM";
                }
            };

            Button copy = new Button()
            {
                Height = 100,
                Width = 100,
                Text = "Copy Userdata",
                Location = new Point(10, 120)
            };
            copy.Click += (o, s) => {
                if (copyC == false)
                {
                    copyC = true;
                    copy.Text = "Copy Userdata ✓";
                }
                else if (copyC)
                {
                    copyC = false;
                    copy.Text = "Copy Userdata";
                }
            };


            //run button
            Button run = new Button()
            {
                Height = 50,
                Width = 100,
                Text = "RUN",
                Location = new Point(10, 300)
            };
            run.Click += (o, s) => {
                Timer.Start();
                //Reset Log
                Process.Start("CMD.exe", "/C clear > log.txt");
                //WinGet
                //Web Browsers
                if (chromeIns)
                {
                    var process = Process.Start("CMD.exe", "/C winget install Google.Chrome");
                    process?.WaitForExit();
                    Console.WriteLine("Installing Chrome - Done");
                }
                if (firefoxIns)
                {
                    var process = Process.Start("CMD.exe", "/C winget install Mozilla.Firefox");
                    process?.WaitForExit();
                    Console.WriteLine("Installing Firefox - Done");
                }
                if (operaIns)
                {
                    var process = Process.Start("CMD.exe", "/C winget install -e --id Opera.Opera");
                    process?.WaitForExit();
                    Console.WriteLine("Installing Opera - Done");
                }
                //Software
                if (steamIns)
                {
                    var process = Process.Start("CMD.exe", "/C winget install Valve.Steam");
                    process?.WaitForExit();
                    Console.WriteLine("Installing Steam - Done");
                }
                if (discordIns)
                {
                    var process = Process.Start("CMD.exe", "/C winget install Discord.Discord");
                    process?.WaitForExit();
                    Console.WriteLine("Installing Discord - Done");
                }

                //command
                if (updateIns)
                {
                    var process = Process.Start("CMD.exe", "/C winget upgrade --all");
                    process?.WaitForExit();
                    Console.WriteLine("Update - Done");
                }

                //Debuger
                if (sfcC)
                {
                    var process = Process.Start("CMD.exe", "/C sfc /scannow >> log.txt");
                    process?.WaitForExit();
                    Console.WriteLine("System File Checker - Done");
                    sfcC = false;
                }
                if (dismC)
                {
                    var process = Process.Start("CMD.exe", "/C DISM /Online /Cleanup-Image /RestoreHealth >> log.txt");
                    process?.WaitForExit();
                    Console.WriteLine("Deployment Image Servicing and Management Fix - Done");
                    dismC = false;
                }
                if (copyC)
                {
                    //Environment.CurrentDirectory = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
                    DirectoryInfo fv = new DirectoryInfo(Environment.CurrentDirectory);
                    string drive = Path.GetPathRoot(fv.FullName);

                    string userpath = Environment.GetEnvironmentVariable("USERPROFILE");
                    string sourceDir = userpath;
                    string destinationDir = drive + @"Users";
                    if (drive == @"C:\")
                    {
                        destinationDir = drive + @"User_Backup";
                    }

                    Console.WriteLine($"src = {sourceDir}");
                    Console.WriteLine($"des = {destinationDir}");
                    Console.WriteLine("Recursive = true");



                    //// Get the directory information using directoryInfo() method
                    //DirectoryInfo folder = new DirectoryInfo(sourceDir);
      
                    //// Calling a folderSize() method
                    //long totalFolderSize = folderSize(folder);
      
                    //Console.WriteLine("Total folder size in bytes: " + totalFolderSize);*/


                    //FileStream s2 = new FileStream("test.txt", FileMode.Open, FileAccess.Write);
                    //Console.WriteLine(s2);



                    CopyDirectory(sourceDir, destinationDir, true);


                    copyC = false;
                }



                Console.WriteLine("DONE");
                Console.WriteLine(Timer.Elapsed.ToString());
                Timer.Stop();
            };

            Button winGet = new Button()
            {
                Height = 100,
                Width = 100,
                Text = "Winget",
                Location = new Point(240, 10)
            };
            winGet.Click += (o, s) => {
                sfc.Visible = false;
                dism.Visible = false;
                copy.Visible = false;
                winGet.Visible = false;
                run.Visible = false;

                //WinGet Menu
                winGetL.Visible = true;
                chrome.Visible = true;
                firefox.Visible = true;
                opera.Visible = true;
                steam.Visible = true;
                discord.Visible = true;
                update.Visible = true;
                winGetBack.Visible = true;
            };
            winGetBack.Click += (o, s) => {
                sfc.Visible = true;
                dism.Visible = true;
                copy.Visible = true;
                winGet.Visible = true;
                run.Visible = true;

                //WinGet Menu
                winGetL.Visible = false;
                chrome.Visible = false;
                firefox.Visible = false;
                opera.Visible = false;
                steam.Visible = false;
                discord.Visible = false;
                update.Visible = false;
                winGetBack.Visible = false;
            };



            myform.Controls.Add(sfc);
            myform.Controls.Add(dism);
            myform.Controls.Add(winGet);
            myform.Controls.Add(copy);

            //WinGet
            myform.Controls.Add(winGetL);
            myform.Controls.Add(chrome);
            myform.Controls.Add(firefox);
            myform.Controls.Add(opera);
            myform.Controls.Add(steam);
            myform.Controls.Add(discord);
            myform.Controls.Add(update);
            myform.Controls.Add(winGetBack);

            myform.Controls.Add(run);
            myform.ShowDialog();

            while (myform.Created)
            {

            }
        }

        static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists) {
                throw new DirectoryNotFoundException("Source directory not found: {" + dir.FullName + "}");
            }


                

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    string targetFilePath = Path.Combine(destinationDir, file.Name);
                    file.CopyTo(targetFilePath);
                    Console.WriteLine(file.FullName + "---" + file.Length + "b");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("ERrOR! FILE ACCESS DENIED, SKIPPING FILE {" + Path.Combine(destinationDir, file.Name) + "}");
                }
                catch (IOException)
                {
                    Console.WriteLine("ERrOR! FILE IN USE OR ALREADY COPIED, SKIPPING FILE {" + Path.Combine(destinationDir, file.Name) + "}");
                }

            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string userpath = Environment.GetEnvironmentVariable("USERPROFILE");
                    string exceptionSpec = subDir.FullName;
                    if (exceptionSpec == userpath + @"\AppData\Local\Microsoft\Windows\INetCache" || exceptionSpec == userpath + @"\AppData\Local\Microsoft\Windows\History" || exceptionSpec == userpath + @"\AppData\Local\Microsoft\Windows\Temporary Internet Files" || exceptionSpec == userpath + @"\AppData\Local\Programdata" || exceptionSpec == userpath + @"\AppData\Local\Temporary Internet Files" || exceptionSpec == userpath + @"\AppData\Local\Tidigare" || exceptionSpec == userpath + @"\AppData\Local\Packages" || exceptionSpec == userpath + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Program" || exceptionSpec == userpath + @"\Cookies" || exceptionSpec == userpath + @"\AppData\Local\Temp\WinSAT" || exceptionSpec == userpath + @"\Documents\Min musik" || exceptionSpec == userpath + @"\Documents\Mina bilder" || exceptionSpec == userpath + @"\Documents\Mina videoklipp" || exceptionSpec == userpath + @"\Lokala inställningar" || exceptionSpec == userpath + @"\Mallar" || exceptionSpec == userpath + @"\Mina dokument" || exceptionSpec == userpath + @"\Nätverket" || exceptionSpec == userpath + @"\Programdata" || exceptionSpec == userpath + @"\Recent" || exceptionSpec == userpath + @"\SendTo" || exceptionSpec == userpath + @"\Skrivare" || exceptionSpec == userpath + @"\Start-meny" || exceptionSpec == userpath + @"\AppData\Local\Application Data" || subDir.FullName.Contains("cache") || subDir.FullName.Contains("Cache") || exceptionSpec == userpath + @"\AppData\Local\History" || exceptionSpec == userpath + @"\Application Data" || exceptionSpec == userpath + @"\Documents\My Music" || exceptionSpec == userpath + @"\Documents\My Pictures" || exceptionSpec == userpath + @"\Documents\My Videos" || exceptionSpec == userpath + @"\Local Settings" || exceptionSpec == userpath + @"\My Documents" || exceptionSpec == userpath + @"\NetHood" || exceptionSpec == userpath + @"\PrintHood" || exceptionSpec == userpath + @"\Start Menu" || exceptionSpec == userpath + @"\Templates" || exceptionSpec == userpath + @"AppData\Local\Temp")
                    {
                        continue;
                    }
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }
        static void PasteDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException("Source directory not found: {" + dir.FullName + "}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                try
                {
                    if (File.Exists(targetFilePath))
                    {
                        string backup = @"C:\DEBUG-BACKUP\";
                        File.Replace(sourceDir + file.FullName, targetFilePath, backup);
                        continue;
                    }

                    file.CopyTo(targetFilePath);
                    Console.WriteLine(file.FullName + "---" + file.Length + "b");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("ERrOR! FILE ACCESS DENIED, SKIPPING FILE {" + Path.Combine(destinationDir, file.Name) + "}");
                }
                catch (IOException)
                {
                    Console.WriteLine("ERrOR! FILE IN USE OR ALREADY EXISTS, TRYING AGAIN {" + Path.Combine(destinationDir, file.Name) + "}");
                    try {
                        //Removes the file that did alredy exist
                        File.Delete(destinationDir);

                        //Copying the file again
                        file.CopyTo(targetFilePath);
                        Console.WriteLine(file.FullName + "---" + file.Length + "b");
                    }
                    catch(IOException) {
                        Console.WriteLine("ERrOR! Destination file is in use¨,  SKIPPING FILE");
                    }
                }

            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string userpath = Environment.GetEnvironmentVariable("USERPROFILE");
                    string exceptionSpec = subDir.FullName;
                    if (exceptionSpec == userpath + @"\AppData\Local\Microsoft\Windows\INetCache" || exceptionSpec == userpath + @"\AppData\Local\Microsoft\Windows\History" || exceptionSpec == userpath + @"\AppData\Local\Microsoft\Windows\Temporary Internet Files" || exceptionSpec == userpath + @"\AppData\Local\Programdata" || exceptionSpec == userpath + @"\AppData\Local\Temporary Internet Files" || exceptionSpec == userpath + @"\AppData\Local\Tidigare" || exceptionSpec == userpath + @"\AppData\Local\Packages" || exceptionSpec == userpath + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Program" || exceptionSpec == userpath + @"\Cookies" || exceptionSpec == userpath + @"\AppData\Local\Temp\WinSAT" || exceptionSpec == userpath + @"\Documents\Min musik" || exceptionSpec == userpath + @"\Documents\Mina bilder" || exceptionSpec == userpath + @"\Documents\Mina videoklipp" || exceptionSpec == userpath + @"\Lokala inställningar" || exceptionSpec == userpath + @"\Mallar" || exceptionSpec == userpath + @"\Mina dokument" || exceptionSpec == userpath + @"\Nätverket" || exceptionSpec == userpath + @"\Programdata" || exceptionSpec == userpath + @"\Recent" || exceptionSpec == userpath + @"\SendTo" || exceptionSpec == userpath + @"\Skrivare" || exceptionSpec == userpath + @"\Start-meny" || exceptionSpec == userpath + @"\AppData\Local\Application Data" || subDir.FullName.Contains("cache") || subDir.FullName.Contains("Cache") || exceptionSpec == userpath + @"\AppData\Local\History" || exceptionSpec == userpath + @"\Application Data" || exceptionSpec == userpath + @"\Documents\My Music" || exceptionSpec == userpath + @"\Documents\My Pictures" || exceptionSpec == userpath + @"\Documents\My Videos" || exceptionSpec == userpath + @"\Local Settings" || exceptionSpec == userpath + @"\My Documents" || exceptionSpec == userpath + @"\NetHood" || exceptionSpec == userpath + @"\PrintHood" || exceptionSpec == userpath + @"\Start Menu" || exceptionSpec == userpath + @"\Templates" || exceptionSpec == userpath + @"AppData\Local\Temp")
                    {
                        continue;
                    }
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // Log the exception, display it, etc
            Console.WriteLine(e.Exception.Message);
        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // Log the exception, display it, etc
            Console.WriteLine((e.ExceptionObject as Exception)?.Message);
        }
    }
}
