using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaArray2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnVetor_Click(object sender, EventArgs e)
        {
            // Aula teste Array e vetor
            // Jonas Valereo Técnico em Informática

            //Declarando o codigo Array e instanciando o vetor tipo int 

            int [] vetor = new int [4];

            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;

            //Declarando a variavel valor para acessar o vetor

            int valor = vetor[1];
            System.Array.Sort(vetor);

            //Declarando o codigo for , percorre o veto em cada indice

            for (int index = 0; index < 4; index++)
            MessageBox.Show(vetor[index].ToString(), "Array");

            //Fim do programa 
        }

        private void BtnTexto_Click(object sender, EventArgs e)
        {
            //Declarando o Array e instanciando o vetor semana tipo string

            string[] semana = new string[7];

            semana[0] = "Domingo";
            semana[1] = "Segunda-feira";
            semana[2] = "Tercça-feira";
            semana[3] = "Quarta-feira";
            semana[4] = "Quinta-feira";
            semana[5] = "Sexta-feira";
            semana[6] = "Sábado";

            //Declranao a variavel valor para acessar o vetor semana

            string valor = semana[1];
            
            //Declarando o codigo for, para percorre em cada indice 

            for (int index = 0; index < 7; index++)
                MessageBox.Show(semana[index].ToString(), "Array");

            //Fim do programa

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            //Declarando o codigo sair close

            Close();

        }
    }
}
