using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class Form1 : Form
    {
        public int retorno = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //O try Executa o codigo dentro dele  se nao houver nenhum erro
            try
            {
                pictureBox1.Image = Image.FromFile(@"C:\img\lol.jpg");
                MessageBox.Show("Caminho da imagem encontrado!");
            }

            //O catch Executa o codigo dentro dele se houver erro
            catch
            {
                retorno += 1;
                if (retorno <= 2)
                {
                    MessageBox.Show("Imagem não encontrada!!");
                }
                else
                {
                    MessageBox.Show("Botão desativado por ocorrer erros consecutivos!!");
                    button1.Enabled = false;
                }
            }
            //O finally sempre sera executado, com ou sem erro no programa 
            //finally
            //{

            //    MessageBox.Show("Código executado no finally");
            //}

        }
    }
}
