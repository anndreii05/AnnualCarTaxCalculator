using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator_POO__3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void calculeaza_Click(object sender, EventArgs e)
        {
            int em, cmc_nr, an_nr;
            string norma_string;
            double suma_plata = 0.0;
            double A, B, C, D, E;
            try
            {
                em = Convert.ToInt32(emisie.Text);
                try
                {
                    cmc_nr = Convert.ToInt32(cmc.Text);
                    try
                    {
                        norma_string = norma.SelectedItem.ToString();
                        try
                        {
                            an_nr = Convert.ToInt32(an.Text);
                            rezultat.Text = "";
                            //CALCULARE TAXA NORMA
                            if (norma_string == "Hibrid" || norma_string == "Electric" || norma_string == "Euro 6")
                            {
                                B = 0;
                            }
                            else if (norma_string == "Euro 3" || norma_string == "Euro 4" || norma_string == "Euro 5")
                            {
                                if (em <= 120) B = 0;
                                else if (em >= 121 && em <= 210) B = em;
                                else if (em >= 211 && em <= 270) B = 4 * em;
                                else B = 8 * em;
                            }
                            else B = 0;

                            //CALCULARE TAXA EMISII
                            if (norma_string == "Hibrid" || norma_string == "Electric" || norma_string == "Euro 6")
                            {
                                D = 0;
                            }
                            else if (norma_string == "Euro 5")
                            {
                                if (cmc_nr <= 2000) D = cmc_nr * 1.3;
                                else D = cmc_nr * 0.39;
                            }
                            else if (norma_string == "Euro 4")
                            {
                                if (cmc_nr <= 2000) D = cmc_nr * 0.13;
                                else D = cmc_nr * 3.0;
                            }
                            else
                            {
                                if (cmc_nr <= 2000) D = cmc_nr * 9.0;
                                else D = cmc_nr * 16.0;
                            }

                            //COTA DE REDUCERE A TAXEI
                            int diferenta_an = 2021 - an_nr;
                            if (diferenta_an == 0)
                            {
                                E = 0;
                            }
                            else if (diferenta_an < 1)
                            {
                                E = 10;
                            }
                            else if (diferenta_an < 3)
                            {
                                E = 30;
                            }                            
                            else if (diferenta_an < 5)
                            {
                                E = 40;
                            }                            
                            else if (diferenta_an < 10)
                            {
                                E = 60;
                            }
                            else
                            {
                                E = 80;
                            }
                            suma_plata = ( ( (em * B * 0.3) + (cmc_nr * D * 0.7) ) * (100 - E)/100 ) / 100;
                            suma_plata = (double)System.Math.Round(suma_plata, 2);
                            String text_final = "Total de plată (preț în euro): ";
                            rezultat.Text += text_final += suma_plata;
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Nu ați scris anul fabricării!\r\nConsultați CIV-ul!", "Atenție!");
                        }
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Nu ați selectat norma!\r\nConsultați CIV-ul!", "Atenție!");
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Nu ați introdus capacitatea cilindrică!\r\nConsultați CIV-ul! ", "Atenție!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Nu ați introdus emisiile! \r\n Consultați CIV-ul!", "Atenție!");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void darkmode_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(46,46,46);
            ForeColor = Color.FromArgb(247, 247, 247);

            darkmode.BackColor = Color.FromArgb(46, 46, 46);
            darkmode.ForeColor = Color.FromArgb(247, 247, 247);
            
            calculeaza.BackColor = Color.FromArgb(46, 46, 46);
            calculeaza.ForeColor = Color.FromArgb(247, 247, 247);

            emisie.BackColor = Color.FromArgb(46, 46, 46);
            emisie.ForeColor = Color.FromArgb(247, 247, 247);

            cmc.BackColor = Color.FromArgb(46, 46, 46);
            cmc.ForeColor = Color.FromArgb(247, 247, 247);

            norma.BackColor = Color.FromArgb(46, 46, 46);
            norma.ForeColor = Color.FromArgb(247, 247, 247);

            an.BackColor = Color.FromArgb(46, 46, 46);
            an.ForeColor = Color.FromArgb(247, 247, 247);

            rezultat.BackColor = Color.FromArgb(46, 46, 46);
            rezultat.ForeColor = Color.FromArgb(247, 247, 247);

            butonLight.BackColor = Color.FromArgb(46, 46, 46);
            butonLight.ForeColor = Color.FromArgb(247, 247, 247);
        }

        private void butonLight_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            ForeColor = SystemColors.ControlText;

            darkmode.BackColor = SystemColors.Control;
            darkmode.ForeColor = SystemColors.ControlText;

            calculeaza.BackColor = SystemColors.Control;
            calculeaza.ForeColor = SystemColors.WindowText;

            emisie.BackColor = SystemColors.Window;
            emisie.ForeColor = SystemColors.WindowText;

            cmc.BackColor = SystemColors.Window;
            cmc.ForeColor = SystemColors.WindowText;

            norma.BackColor = SystemColors.Window;
            norma.ForeColor = SystemColors.WindowText;

            an.BackColor = SystemColors.Window;
            an.ForeColor = SystemColors.WindowText;

            rezultat.BackColor = SystemColors.Control;
            rezultat.ForeColor = SystemColors.WindowText;

            butonLight.BackColor = SystemColors.Control;
            butonLight.ForeColor = SystemColors.WindowText;
        }
    }
}
