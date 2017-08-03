using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoMem
{
    public partial class Form1 : Form
    {
            
        // escolher icones aleatorios para os labels
        Random random = new Random();

        // Comando list cria uma lista de strings
        List<string> icones = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
            
        };

        private void ColocarIconesNosQuadrados()
        {
            // Adicionar uma string da lista pra cada tableLayout   
            foreach(Control controle in tableLayoutPanel1.Controls)
            {
                Label iconLabel = controle as Label;
                if(iconLabel != null)
                {
                    // Adicionando as letras aleatorias nos labels
                    int numAleat = random.Next(icones.Count);
                    iconLabel.Text = icones[numAleat];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icones.RemoveAt(numAleat);
                }        
            }
        }
        public Form1()
        {
            InitializeComponent();
            ColocarIconesNosQuadrados();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;


                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }

                

                segundoClicado = Labelclicado;
                segundoClicado.ForeColor = Color.Black;

                if (primeiroClicado.Text == segundoClicado.Text)
                {
                    primeiroClicado = null;
                    segundoClicado = null;
                    return;
                }
                timer1.Start();
            }
        }

           

        private void label2_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;

                

                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
                segundoClicado = Labelclicado;
                segundoClicado.ForeColor = Color.Black;

                if (primeiroClicado.Text == segundoClicado.Text)
                {
                    primeiroClicado = null;
                    segundoClicado = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;
             

                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
                segundoClicado = Labelclicado;
                segundoClicado.ForeColor = Color.Black;

               

                if (primeiroClicado.Text == segundoClicado.Text)
                {
                    primeiroClicado = null;
                    segundoClicado = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;
               

                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
                segundoClicado = Labelclicado;
                segundoClicado.ForeColor = Color.Black;

                
                if (primeiroClicado.Text == segundoClicado.Text)
                {
                    primeiroClicado = null;
                    segundoClicado = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;


                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
                segundoClicado = Labelclicado;
                segundoClicado.ForeColor = Color.Black;

               
                if (primeiroClicado.Text == segundoClicado.Text)
                {
                    primeiroClicado = null;
                    segundoClicado = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;


                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
                segundoClicado = Labelclicado;
                segundoClicado.ForeColor = Color.Black;

                if (primeiroClicado.Text == segundoClicado.Text)
                {
                    primeiroClicado = null;
                    segundoClicado = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;

                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
                segundoClicado = Labelclicado;
                segundoClicado.ForeColor = Color.Black;

               
                if (primeiroClicado.Text == segundoClicado.Text)
                {
                    primeiroClicado = null;
                    segundoClicado = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;


                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
                segundoClicado = Labelclicado;
                segundoClicado.ForeColor = Color.Black;

                
                if (primeiroClicado.Text == segundoClicado.Text)
                {
                    primeiroClicado = null;
                    segundoClicado = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;


                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
                segundoClicado = Labelclicado;
                segundoClicado.ForeColor = Color.Black;

               
                if (primeiroClicado.Text == segundoClicado.Text)
                {
                    primeiroClicado = null;
                    segundoClicado = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;


                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
                segundoClicado = Labelclicado;
                segundoClicado.ForeColor = Color.Black;

                
                if (primeiroClicado.Text == segundoClicado.Text)
                {
                    primeiroClicado = null;
                    segundoClicado = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;


                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
                segundoClicado = Labelclicado;
                segundoClicado.ForeColor = Color.Black;

               
                if (primeiroClicado.Text == segundoClicado.Text)
                {
                    primeiroClicado = null;
                    segundoClicado = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;


                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
                segundoClicado = Labelclicado;
                segundoClicado.ForeColor = Color.Black;

                
                if (primeiroClicado.Text == segundoClicado.Text)
                {
                    primeiroClicado = null;
                    segundoClicado = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;


                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
                segundoClicado = Labelclicado;
                segundoClicado.ForeColor = Color.Black;

                
                if (primeiroClicado.Text == segundoClicado.Text)
                {
                    primeiroClicado = null;
                    segundoClicado = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;


                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
            }
            segundoClicado = Labelclicado;
            segundoClicado.ForeColor = Color.Black;

            
            if (primeiroClicado.Text == segundoClicado.Text)
            {
                primeiroClicado = null;
                segundoClicado = null;
                return;
            }

            timer1.Start();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;


                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
            }
            segundoClicado = Labelclicado;
            segundoClicado.ForeColor = Color.Black;

            
            if (primeiroClicado.Text == segundoClicado.Text)
            {
                primeiroClicado = null;
                segundoClicado = null;
                return;
            }

            timer1.Start();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Label Labelclicado = sender as Label;

            if (Labelclicado != null)
            {
                if (Labelclicado.ForeColor == Color.Black)
                    return;


                if (primeiroClicado == null)
                {
                    primeiroClicado = Labelclicado;
                    primeiroClicado.ForeColor = Color.Black;
                    return;
                }
            }
            segundoClicado = Labelclicado;
            segundoClicado.ForeColor = Color.Black;
            

            if (primeiroClicado.Text == segundoClicado.Text)
            {
                primeiroClicado = null;
                segundoClicado = null;
                return;
            }
            

            timer1.Start();
        }


         Label primeiroClicado = null;
         Label segundoClicado = null;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //para o temporizador
            timer1.Stop();

            // Esconde os dois icones
            primeiroClicado.ForeColor = primeiroClicado.BackColor;
            segundoClicado.ForeColor = segundoClicado.BackColor;

            
            primeiroClicado = null;
            segundoClicado = null;
        }

        private void vcGanhou()
        {
            foreach (Control controle in tableLayoutPanel1.Controls)
            {
                Label iconLabel = controle as Label;

                if(iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
                MessageBox.Show("Parabéns voce ganhou!!");
                Close();
            }
        }
    }
}
    