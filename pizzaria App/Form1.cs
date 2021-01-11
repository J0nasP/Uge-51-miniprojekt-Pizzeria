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
    public partial class Bestillings_vindue : Form
    {
        public Bestillings_vindue()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        #region button methods

        //Method that opens a new form containing the possible extra topping possibilities
        private void open_tilbehoer()
        {
            Tilbehør form2 = new Tilbehør();
            form2.ShowDialog();
        }

        private void open_godkendt()
        {
            godkendt_bestilling form3 = new godkendt_bestilling();
            form3.ShowDialog();
        }


        #endregion

        private void bestillings_tabel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tilbehoer_skinke_60_Click(object sender, EventArgs e)
        {
            open_tilbehoer();
        }

        private void tilbehoer_skinke_90_Click(object sender, EventArgs e)
        {
            open_tilbehoer();
        }

        private void tilbehoer_peperoni_60_Click(object sender, EventArgs e)
        {
            open_tilbehoer();
        }

        private void tilbehoer_peperoni_90_Click(object sender, EventArgs e)
        {
            open_tilbehoer();
        }

        private void tilbehoer_salat_60_Click(object sender, EventArgs e)
        {
            open_tilbehoer();
        }

        private void tilbehoer_salat_90_Click(object sender, EventArgs e)
        {
            open_tilbehoer();
        }

        private void tilbehoer_fantasi_60_Click(object sender, EventArgs e)
        {
            open_tilbehoer();
        }

        private void tilbehoer_fantasi_90_Click(object sender, EventArgs e)
        {
            open_tilbehoer();
        }

        private void bestil_button_Click(object sender, EventArgs e)
        {
            open_godkendt();
        }
    }
}
