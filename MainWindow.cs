using System;
using System.Threading;
using System.Windows.Forms;

namespace GTATools
{
    public partial class MainWindow : Form
    {
        public static bool antiAfkEnabled = false;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void antiAfkCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            antiAfkEnabled = antiAfkCheckbox.Checked;
        }
    }
}
