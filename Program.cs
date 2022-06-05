using Arc_Station_View.Data;
using Arc_Station_View.Windows;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Arc_Station_View
{

    /// <summary>
    /// 
    /// Station Viewer
    /// Developed by: Marco (Maerciezz)
    /// Started this project on 5th July 2021.
    /// 
    /// Still in developement.
    /// 
    /// </summary>

    class Program
    {
        public static Splash spl = new Splash();
        public static bool showSplashScreen = true;

        [STAThread]
        static void Main(string[] args)
        {
            Console.Title = "Arc Station Viewer - Console";
            Application.EnableVisualStyles();
            Console.WriteLine(@"/-------------------------------------\");
            Console.WriteLine(@"|            STATION VIEW             |");
            Console.WriteLine(@"\-------------------------------------/");

            LogMessage("> Opening Splash Loading screen...");
            Thread splash = new Thread(new ThreadStart(Program.ShowSplash));
            splash.Start();

            // Loading settings into memory
            LogMessage("> Initializing settings...");
            Thread.Sleep(20);
            try
            {
                Settings.LoadSettings();
                LogMessage("> Settings loaded from config.");
            }
            catch (Exception ex)
            {
                LogMessage("> Error while loading settings: ");
                LogMessage(ex.Message);
            }

            // Code to connect to DB.
            LogMessageLine("> Trying to connect to SQL Server...");
            Thread.Sleep(300);
            try
            {
                Database.OpenConnection();

                LogMessage(" Done!");
            }
            catch (Exception ex)
            {
                LogMessage("> Failed to connect: ");
                LogMessage(ex.Message);
                MessageBox.Show("An error occured when connecting to the SQL server." + Environment.NewLine + ex.Message, "Arc Station View", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.CloseConnection();
            }

            // Starting main thread
            LogMessage("> Starting main program thread...");

            Thread main = new Thread(new ThreadStart(Program.MainWindow));
            main.SetApartmentState(ApartmentState.STA);
            main.Start();
            main.Join();

            LogMessage("Closing open windows...");

            LogMessage("Saving settings...");

            LogMessageLine(DateTime.Now + " : Disconneting from database...");
            try
            {
                Database.CloseConnection();
                Console.WriteLine(" Done!");
            }
            catch
            {
                Console.WriteLine(" Already closed.");
            }

            LogMessage("Exiting application...");
        }

        // Simple method to create log messages into the console.
        public static void LogMessage(string msg)
        {
            Console.WriteLine("{0} : {1}", DateTime.Now, msg);
        }

        public static void LogMessageLine(string msg)
        {
            Console.Write(msg);
        }

        // Thread to start the main window.
        static void MainWindow()
        {
            Application.Run(new MainScreen());
        }

        static void ShowSplash()
        {
            spl.Show();
            while(showSplashScreen == true)
            {
                Thread.Sleep(500);
            }
            spl.Close();
        }

    }
}
