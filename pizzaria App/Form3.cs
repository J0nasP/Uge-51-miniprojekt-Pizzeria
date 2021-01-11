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
    public partial class godkendt_bestilling : Form
    {
        public godkendt_bestilling()
        {
            InitializeComponent();
        }

        private void luk_vinduet_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}