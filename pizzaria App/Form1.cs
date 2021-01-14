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



        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        #region udregning af pris

        private int udregning_skinke(Label skinke_60, Label skinke_90)
        {
            int total_pris_skinke = Convert.ToInt32(skinke_60) + Convert.ToInt32(skinke_90);
            return total_pris_skinke;
        }

        private void udregning()
        {
            
        }
        private int udregning_peperoni(Label peperoni_60, Label peperoni_90)
        {
           int total_pris_peperoni = Convert.ToInt32(peperoni_60) + Convert.ToInt32(peperoni_90);
           return total_pris_peperoni;
        }

        private int udregning_salat(Label salat_60, Label salat_90)
        {
            int total_pris_salat = Convert.ToInt32(salat_60) + Convert.ToInt32(salat_90);
            return total_pris_salat;
        }

        private int udregning_fantasi(Label fantasi_60, Label fantasi_90)
        {
            int total_pris_fantasi = Convert.ToInt32(fantasi_60) + Convert.ToInt32(fantasi_90);
            return total_pris_fantasi;
        }



        private void udregning_60_cm(NumericUpDown antal, Label pris_total)
        {
            decimal value = antal.Value * 70;
            pris_total.Text = value.ToString() + " kr";
        }

        private void udregning_90_cm(NumericUpDown antal, Label pris_total)
        {
            decimal value = antal.Value * 140;
            pris_total.Text = value.ToString() + " kr";
        }

        private void udregning_lille_soda(NumericUpDown antal, Label pris_total)
        {
            decimal value = antal.Value * 15;
            pris_total.Text = value.ToString() + " kr";
        }

        private void udregning_mellem_soda(NumericUpDown antal, Label pris_total)
        {
            decimal value = antal.Value * 20;
            pris_total.Text = value.ToString() + "kr";
        }

        private void udregning_stor_soda(NumericUpDown antal, Label pris_total)
        {
            decimal value = antal.Value * 30;
            pris_total.Text = value.ToString() + "kr";
        }

        #endregion

        #region open new form buttons
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

        #endregion


    }
}
