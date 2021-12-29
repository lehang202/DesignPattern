using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class GotoForm : Form
    {
        private string _message;
        public GotoForm()
        {
            InitializeComponent();
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            this.Message = inputBox.Text;
            this.Close();
        }

        private void GotoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
