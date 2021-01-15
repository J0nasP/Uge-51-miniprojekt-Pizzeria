using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaria_App
{
    public partial class Tilbehør : Form
    {
        public Tilbehør()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void afbryd_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
