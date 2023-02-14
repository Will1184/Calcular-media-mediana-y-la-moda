using System;

namespace GM21057Guia4EJercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void botonIngresarCantidad_Click(object sender, EventArgs e)
        {
            //Creacion de variables
            int cantidadDatos; double numeros = 0, media;
            int c = 0, contadorAntes = 0, contadorDespues = 0;
            double sumaMedia = 0, mediana = 0, moda = 0;
            double mPrimero = 0, mSegundo = 0;
 

            //Proceso
            cantidadDatos = int.Parse(ingresarCantidadDatos.Text);
            double[] sumaModa = new double[cantidadDatos];


            for (int i = 0; i < cantidadDatos; i++)
            {
                c++;
                numeros = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero: " + c));
                sumaModa[i] = numeros;
                sumaMedia = sumaMedia + numeros;
         

            }
            //Calculo para sacar la media

            media = sumaMedia / cantidadDatos;

            //Calculo para sacar la mediana
            double pos = sumaMedia / 2;
            if (sumaMedia % 2 == 0)
            {
                mediana = (pos - 1) + (pos) / 2.0;

            }
            else
            {
                mediana = pos;
            }

            //Caclulo para sacar la moda
            for (int i = 0; i < sumaModa.Length; i++)
            {
                 mPrimero = sumaModa[i];

                for (int j = 0; j < sumaModa.Length; j++)
                {
                     mSegundo = sumaModa[j];
                    if (mPrimero == mSegundo )
                    {
                        contadorDespues++;
                        moda = mPrimero;
                    }
                   
                }
                if (contadorDespues != 1)
                {
                    if (contadorAntes < contadorDespues)
                    {
                        contadorAntes = contadorDespues;
                        textModa.Text =moda.ToString() ;
                    }

                }
            }
            textMediana.Text = mediana.ToString();
            texMedia.Text = media.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}