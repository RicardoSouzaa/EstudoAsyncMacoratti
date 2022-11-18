using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteWfAsyncMacoratti
{
    public partial class Form1 : Form
    {
        int cliques = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // primeira task que executa
            Console.WriteLine("Evento do botão foi iniciado : Cliqui aqui");

            //executa o longa --- primeiro verifica bisexto, espera 10 segs e finalizar
            Teste teste = new Teste();
            await teste.Task_LongaDuracao();

            // apoós o fim do task longo ele imprime
            Console.WriteLine("Evento do botão foi concluído");

            Console.WriteLine($"você clicou {++cliques} vezes ------------ {DateTime.Now} ");
        }
    }
}