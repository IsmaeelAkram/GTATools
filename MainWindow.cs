using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace GTATools
{
    public partial class MainWindow : Form
    {
        public static bool antiAfkEnabled = false;
        Thread antiAfkThread = new Thread(new ThreadStart(antiAfk));

        public MainWindow()
        {
            InitializeComponent();

            this.Cursor = new Cursor(Cursor.Current.Handle);
            
            antiAfkThread.Start();
            Console.WriteLine("Anti-AFK thread started.");
        }
        
        public static void antiAfk()
        {
            while (true)
            {
                if (antiAfkEnabled)
                {
                    // TODO: Move mouse
                    Cursor.Position = new Point(Cursor.Position.X + 300, Cursor.Position.Y);
                    Thread.Sleep(1000);
                    Cursor.Position = new Point(Cursor.Position.X - 300, Cursor.Position.Y);
                }
                Thread.Sleep(3000);
            }
        }

        public static void makeSoloSession()
        {
            var GTAProcesses = Process.GetProcessesByName("GTAV.exe");
            var GTAProcess = new Process();

            if(GTAProcesses.Length == 0)
            {
                MessageBox.Show("GTA doesn't appear to be running!");
                return;
            }else
            {
                GTAProcess = GTAProcesses[0];
            }

            ProcessExtension.Suspend(GTAProcess);
            Thread.Sleep(15000);
            ProcessExtension.Resume(GTAProcess);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void antiAfkCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            antiAfkEnabled = antiAfkCheckbox.Checked;
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            antiAfkThread.Abort();
        }

        private void privateSessionBtn_Click(object sender, EventArgs e)
        {
            makeSoloSession();
        }
    }
}
