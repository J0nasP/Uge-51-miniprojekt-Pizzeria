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


        #region open new form button methods

        //Method that opens a new form containing the possible extra topping possibilities
        private void open_tilbehoer()
        {
            Tilbehør form2 = new Tilbehør();
            form2.ShowDialog();
        }

        // Method taht opens a new form containing the "godkendt ordrer"
        private void open_godkendt_order()
        {
            godkendt_bestilling form3 = new godkendt_bestilling();
            form3.ShowDialog();
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
            open_godkendt_order();
        }


        #endregion


        #region udregning af pris på pizza

        private int udregning_skinke(Label skinke_60, Label skinke_90)
        {
            int total_pris_skinke = Convert.ToInt32(skinke_60.Text) + Convert.ToInt32(skinke_90.Text);
            return total_pris_skinke;
        }


        private int udregning_peperoni(Label peperoni_60, Label peperoni_90)
        {
            int total_pris_peperoni = Convert.ToInt32(peperoni_60.Text) + Convert.ToInt32(peperoni_90.Text);
            return total_pris_peperoni;
        }

        private int udregning_salat(Label salat_60, Label salat_90)
        {
            int total_pris_salat = Convert.ToInt32(salat_60.Text) + Convert.ToInt32(salat_90.Text);
            return total_pris_salat;
        }

        private int udregning_fantasi(Label fantasi_60, Label fantasi_90)
        {
            int total_pris_fantasi = Convert.ToInt32(fantasi_60.Text) + Convert.ToInt32(fantasi_90.Text);
            return total_pris_fantasi;
        }

        private void udregning_pizza_total(Label total_pizza_label)
        {
            int skinke = udregning_skinke(skinke_60_pris_total, skinke_90_pris_total);
            int peperoni = udregning_peperoni(peperoni_60_pris_total, peperoni_90_pris_total);
            int salat = udregning_salat(salat_60_pris_total, salat_90_pris_total);
            int fantasi = udregning_fantasi(fantasi_60_pris_total, fantasi_90_pris_total);

            int pizza_total_number = skinke + peperoni + salat + fantasi;
            total_pizza_label.Text = pizza_total_number.ToString() + " kr";
        }
        



        #endregion

        #region udregning af pris på størrelser
        private void udregning_60_cm(NumericUpDown antal, Label pris_total)
        {
            decimal value = antal.Value * 70;
            pris_total.Text = value.ToString();
        }

        private void udregning_90_cm(NumericUpDown antal, Label pris_total)
        {
            decimal value = antal.Value * 140;
            pris_total.Text = value.ToString();
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

        #region udregning af pizza metoder "label value change"

        private void udregning_pizza_total_label()
        {
            udregning_pizza_total(pizza_total_pris);
        }

        private void udregning_salat_60_label()
        {
            udregning_60_cm(antal_60_salat, salat_60_pris_total);
            
        }

        private void udregning_salat_90_label()
        {
            udregning_90_cm(antal_90_salat, salat_90_pris_total);
        }

        private void udregning_peperoni_60_label()
        {
            udregning_60_cm(antal_60_peperoni, peperoni_60_pris_total);
        }

        private void udregning_peperoni_90_label()
        {
            udregning_90_cm(antal_90_peperoni, peperoni_90_pris_total);
        }

        private void udregning_skinke_60_label()
        {
            udregning_60_cm(antal_60_skinke, skinke_60_pris_total);
        }

        private void udregning_skinke_90_label()
        {
            udregning_90_cm(antal_90_skinke, skinke_90_pris_total);
        }

        private void udregning_fantasi_60_label()
        {
            udregning_60_cm(antal_60_fantasi, fantasi_60_pris_total);
        }

        private void udregning_fantasi_90_label()
        {
            udregning_90_cm(antal_90_fantasi, fantasi_90_pris_total);
        }


        #endregion 

        #region udregning af sodavand metoder "label value change"
        private void udregning_cola_lille_label()
        {
            udregning_lille_soda(antal_cola_33, cola_33_pris);
        }

        private void udregning_cola_mellem_label()
        {
            udregning_mellem_soda(antal_cola_50, cola_50_pris);
        }

        private void udregning_cola_stor_label()
        {
            udregning_stor_soda(antal_cola_150, cola_150_pris);
        }

        private void udregning_fanta_lille_label()
        {
            udregning_lille_soda(antal_fanta_33, fanta_33_pris);
        }

        private void udregning_fanta_mellem_label()
        {
            udregning_mellem_soda(antal_fanta_50, fanta_50_pris);
        }

        private void udregning_fanta_stor()
        {
            udregning_stor_soda(antal_fanta_150, fanta_150_pris);
        }

        private void udregning_sprite_lille()
        {
            udregning_lille_soda(antal_sprite_33, sprite_33_pris);
        }

        private void udregning_sprite_mellem()
        {
            udregning_mellem_soda(antal_sprite_50, sprite_50_pris);
        }
        
        private void udregning_sprite_stor()
        {
            udregning_stor_soda(antal_sprite_150, sprite_150_pris);
        }

        #endregion


        #region udregning af pris pizza buttons
        private void udregning_salat_60_button(object sender, EventArgs e)
        {
            udregning_salat_60_label();
            udregning_pizza_total_label();
        }

        private void udregning_salat_90_button(object sender, EventArgs e)
        {
            udregning_salat_90_label();
            udregning_pizza_total_label();
        }

        private void udregning_skinke_60_button(object sender, EventArgs e)
        {
            udregning_skinke_60_label();
            udregning_pizza_total_label();
        }

        private void udregning_skinke_90_button(object sender, EventArgs e)
        {
            udregning_skinke_90_label();
            udregning_pizza_total_label();
        }

        private void udregning_peperoni_60_button(object sender, EventArgs e)
        {
            udregning_peperoni_60_label();
            udregning_pizza_total_label();
        }

        private void udregning_peperoni_90_button(object sender, EventArgs e)
        {
            udregning_peperoni_90_label();
            udregning_pizza_total_label();
        }

        private void udregning_fantasi_60_button(object sender,EventArgs e)
        {
            udregning_fantasi_60_label();
            udregning_pizza_total_label();
        }

        private void udregning_fantasi_90_button(object sender, EventArgs e)
        {
            udregning_fantasi_90_label();
            udregning_pizza_total_label();
        }

        #endregion

        #region udregning af pris sodavand buttons
        private void udregning_lille_cola_button(object sender, EventArgs e)
        {
            udregning_cola_lille_label();
        }

        private void udregning_mellem_cola_button(object sender, EventArgs e)
        {
            udregning_cola_mellem_label();
        }

        private void udregning_stor_cola_button(object sender, EventArgs e)
        {
            udregning_cola_stor_label();
        }

        private void udregning_lille_sprite_button(object sender, EventArgs e)
        {
            udregning_sprite_lille();
        }

        private void udregning_mellem_sprite_button(object sender, EventArgs e)
        {
            udregning_sprite_mellem();
        }

        private void udregning_stor_sprite_button(object sender, EventArgs e)
        {
            udregning_sprite_stor();        
        }

        private void udregning_lille_fanta_button(object sender, EventArgs e)
        {
            udregning_fanta_lille_label();
        }

        private void udregning_mellem_fanta_button(object sender, EventArgs e)
        {
            udregning_fanta_mellem_label();
        }

        private void udregning_stor_fanta_button(object sender, EventArgs e)
        {
            udregning_fanta_stor();
        }
        #endregion
    }
}
