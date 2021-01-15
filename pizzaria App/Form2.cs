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

        #region button metoder
        private void afbryd_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tilfoej_button_click(object sender, EventArgs e)
        {
            check_listbox();
            this.Close();
        }

        #endregion

        #region listbox metoder

        private void check_listbox()
        {
            if (tilbehoer_box.CheckedItems.Count != 0 )
            {
                int i;
                string s;
                s = "Valgt tilbehør: \n";
                for (i = 0; i <= (tilbehoer_box.Items.Count-1); i++)
                {
                    if (tilbehoer_box.GetItemChecked(i))
                    {
                        s = s + "Tilbehør " + (i+1).ToString() + " = " + tilbehoer_box.Items[i].ToString() + "\n" ;
                    }
                }
                MessageBox.Show(s);
            }
        }

        private int antal_tilbehoer_check()
        {
            int antal_tilbehoer;

            return antal_tilbehoer = tilbehoer_box.Items.Count;
        }


        #endregion
    }
}
