using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoRPG01
{


    public partial class Form1 : Form
    {
        private Jogador j1;
        private Jogador j2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            j1 = new Jogador(1, 10, 6, 3);
            lblAtaqueJ1.Text = j1.getAtaqueP().ToString();
            lblDefesaJ1.Text = j1.getDefesaP().ToString();
            lblVidaJ1.Text = j1.getVida().ToString();
            j2 = new Jogador(2, 6, 5, 4);
            lblAtaqueJ2.Text = j2.getAtaqueP().ToString();
            lblDefesaJ2.Text = j2.getDefesaP().ToString();
            lblVidaJ2.Text = j2.getVida().ToString();

            lblDanoJ1.Text = "";
            lblDanoJ2.Text = "";

            pbxJ1.ImageLocation = "../../../Default (Azul).png";
            pbxJ2.ImageLocation = "../../../Default (Red).png";

            TurnoJ1();
        }


        private void TurnoJ1()
        {
            if (seVivos())
            {

                 btnAtaqueJ1.Enabled = true;
                 btnDefesaJ1.Enabled = true;

                 btnAtaqueJ2.Enabled = false;
                 btnDefesaJ2.Enabled = false;

                 j1.setDefesa(j1.getDefesaP());
                 j1.setAtaque(j1.getAtaqueP());

                 pbxJ1.ImageLocation = "../../../Default (Azul).png";
            }
        }


        private void TurnoJ2()
        {
            if (seVivos())
            {
                btnAtaqueJ2.Enabled = true;
                btnDefesaJ2.Enabled = true;

                btnAtaqueJ1.Enabled = false;
                btnDefesaJ1.Enabled = false;

                j2.setDefesa(j2.getDefesaP());
                j2.setAtaque(j2.getAtaqueP());

                pbxJ2.ImageLocation = "../../../Default (Red).png";
            }
            
        }

        private bool seVivos()
        {
            if (j1.getVida() > 0 && j2.getVida() > 0)
            {
                return true;
            }
            else if(j1.getVida() >= 0)
            {
                ptbFinal.Visible = true;
                btnReiniciar.Visible = true;
                btnReiniciar.BringToFront();
                ptbFinal.ImageLocation = "../../../Player1.png";
                return false;
            }
            else
            {
                ptbFinal.Visible = true;
                btnReiniciar.Visible = true;
                btnReiniciar.BringToFront();
                ptbFinal.ImageLocation = "../../../Player2.png";
                return false;
            }
           
        }

        private void btnAtaqueJ1_Click(object sender, EventArgs e)
        {
            btnAtaqueJ1.Enabled=false;
            if (seVivos())
            {
                lblAtaqueJ1.Text = j1.Ataque().ToString();
                pbxJ1.ImageLocation = "../../../Ataque (Azul).png";
                if (j1.getAtaque() > j2.getDefesa())
                {
                    int dano = (j1.getAtaque() - j2.getDefesa());
                    j2.setVida(j2.getVida() - dano);

                    pbxJ2.ImageLocation = "../../../Ferido (Red).png";

                    if(j2.getVida() > 0)
                    {
                        lblVidaJ2.Text = j2.getAtaque().ToString();
                    }
                    else
                    {
                        lblVidaJ2.Text = "0";
                    }

                    //lblVidaJ2.Text = j2.getVida().ToString();
                    lblDanoJ2.Text = "-"+dano.ToString();

                    Esperar(500, 1);
                }
                else
                {
                    lblDanoJ2.Text = "MISS"; TurnoJ2(); ;
                }
            }
        }
            private async void Esperar(int delay, int jogador)
            {
                await Task.Delay(delay);
                if (jogador == 1)
                {
                    TurnoJ2();
                }
                else
                {
                    TurnoJ1();
                }
            }

            private void btnDefesaJ1_Click(object sender, EventArgs e)
            {
                if (seVivos())
                {
                    lblDefesaJ1.Text = j1.Defesa().ToString();
                    pbxJ1.ImageLocation = "../../../Default (Azul).png";
                    TurnoJ2();

                }
            }

            private void btnAtaqueJ2_Click(object sender, EventArgs e)
            {
                btnAtaqueJ2.Enabled = false;
                if (seVivos())
                {
                    lblAtaqueJ1.Text = j2.Ataque().ToString();
                    pbxJ2.ImageLocation = "../../../Ataque (Red).png";
                    if (j2.getAtaque() > j1.getDefesa())
                    {
                        int dano = (j2.getAtaque() - j1.getDefesa());
                        j1.setVida(j1.getVida()-dano);

                        pbxJ1.ImageLocation = "../../../Ferido (Azul).png";

                    if (j1.getVida() > 0)
                    {
                        lblVidaJ1.Text = j1.getAtaque().ToString();
                    }
                    else
                    {
                        lblVidaJ1.Text = "0";
                    }

                    //lblVidaJ1.Text = j1.getVida().ToString();
                        lblDanoJ1.Text = "-" + dano.ToString();
                        Esperar(500, 2);
                    }
                    else
                    {
                        lblDanoJ1.Text = "MISS"; TurnoJ1(); ;
                    }


                }
            }

            private void btnDefesaJ2_Click(object sender, EventArgs e)
            {
                if (seVivos())
                {
                    lblDefesaJ2.Text = j2.Defesa().ToString();
                    pbxJ2.ImageLocation = "../../../Default (Red).png";
                    TurnoJ1();
                }

            }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ptbFinal.Visible = false;
            btnReiniciar.Visible = false;
            this.Form1_Load(this ,e);

        }
    }
}

    
