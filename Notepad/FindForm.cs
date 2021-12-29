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
    public partial class FindForm : Form
    {
        private string find;
        public FindForm()
        {
            InitializeComponent();
        }

        public string Findtext
        {
            get { return find; }
            set { find = value; }
        }

        private void FindForm_Load(object sender, EventArgs e)
        {
        }

        private void findbnt_Click(object sender, EventArgs e)
        {
            this.Findtext = findTextBox.Text;
            this.Close();
        }
    }
}
