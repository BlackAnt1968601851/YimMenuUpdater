using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YimUpdater
{
    public partial class Download_Error : Form
    {
        public static string? errormessage;
        public Download_Error(string? errorcode)
        {
            InitializeComponent();
            errormessage = errorcode;
        }

        private void Download_Error_Load(object sender, EventArgs e)
        {
            if (errormessage == null)
            {
                textBox1.Text = "Cannot get error message something unknown happened.";
            }
            if (!(errormessage == null))
            {
                textBox1.Text = errormessage;
            }
        }
    }
}
