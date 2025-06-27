using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_tools_Form_Apps.MessageBoxs
{
    public partial class single_download : Form
    {
        Form wf;
        public single_download(Form window, string appname)
        {
            InitializeComponent();

            tool_name.Text = appname + " 可以下載獨立化工具!";
            wf = window;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void download_Click(object sender, EventArgs e)
        {
            wf.ShowDialog();
            this.Close();
        }
    }
}
