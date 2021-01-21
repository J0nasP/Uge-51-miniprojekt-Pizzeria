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
            check_antal_up_down();
            check_listbox();
            this.Close();
        }

        #endregion

        #region listbox message metoder

        private void check_listbox()
        {

            if (tilbehoer_box.CheckedItems.Count != 0 )
            {
                int i;
                string message;
                message = "Valgt tilbehør: \n";
                for (i = 0; i <= (tilbehoer_box.Items.Count-1); i++)
                {
                    if (tilbehoer_box.GetItemChecked(i))
                    {
                       message = message + "Tilbehør " + (i+1).ToString() + " = " + tilbehoer_box.Items[i].ToString() + "\n" ;
                    }
                }
                MessageBox.Show(message);
                antal_tilbehoer_check();
            }
            else
            {
                string fejl = " Fejl! \n Du har ikke valgt noget tilbehør";
                MessageBox.Show(fejl);
            }

        }

        private int antal_tilbehoer_check()
        {
            int antal_tilbehoer;

            return antal_tilbehoer = tilbehoer_box.Items.Count;
        }

        #endregion

        private void check_antal_up_down()
        {
            if (antal_up_down.Value == 0)
            {
                string fejl = "  Fejl! \n Antallet af pizza'er kan ikke være 0";
                MessageBox.Show(fejl);
            }
        }

        private int total_antal_tilbehoer()
        {
            int antal_tilbehoer = tilbehoer_box.Items.Count;
            decimal antal_aendringer = antal_up_down.Value;

            int totale_aendringer = (int) (antal_aendringer + antal_tilbehoer);

            return totale_aendringer;
        }
    }
}
