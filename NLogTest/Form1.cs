using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLogTest
{
    public partial class Form1 : Form
    {
        public static Logger LogInstance { get; private set; }
        public Form1()
        {
            InitializeComponent();
            LogInstance = LogManager.GetCurrentClassLogger();
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            LogInstance.Debug("Debug message");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            LogInstance.Info("Info message");
        }

        private void btnWarn_Click(object sender, EventArgs e)
        {
            LogInstance.Warn("Warn message");
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            LogInstance.Error("Error message");
        }

        private void btnFatal_Click(object sender, EventArgs e)
        {
            LogInstance.Fatal("Fatal message");
        }

        private void btnTrace_Click(object sender, EventArgs e)
        {
            LogInstance.Trace("Trace message");
        }
    }
}
