using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

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
        }

        public static void antiAfk()
        {
            while (true)
            {
                if (antiAfkEnabled)
                {
                    // TODO: Move mouse
                    Cursor.Position = new Point(Cursor.Position.X + 300, Cursor.Position.Y);
                }
                Thread.Sleep(15000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            antiAfkThread.Abort();
        }

        private void antiAfkCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            antiAfkEnabled = antiAfkCheckbox.Checked;
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
