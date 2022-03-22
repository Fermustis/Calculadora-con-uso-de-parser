using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _24_02_2022_WFCalculadoraX1
{
    public partial class Form1 : Form
    {
        double x, y, r;
        string mensaje;
        string fx;//guarda lo que le metemos en el cuadro de funcion f(x)
        string fxy;
        CalculadoraBasica cbasica;
        public Form1()
        {
            InitializeComponent();
            cbasica = new CalculadoraBasica();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            Entrada();
          mensaje = cbasica.Suma(x, y, ref r);
            Salida(r);
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            
            try {
                Entrada();
                mensaje = cbasica.division(x, y, ref r);
                Salida(r);
            } catch {
                MessageBox.Show("Error de datos...");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Entrada();
            mensaje = cbasica.cos(x, y, ref r);
            Salida(r);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)//boton fx
        {
            try
            {
                Entrada();
                mensaje = cbasica.fu(x, fx, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de datos...");
            }
        }

        private void button16_Click(object sender, EventArgs e)//fxy
        {
            try
            {
                Entrada();
                mensaje = cbasica.fu2(x,y, fxy, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error de datos...");
            }
        }

        private void btfl_Click(object sender, EventArgs e)//aplicacion aparte para compuertas logicas
        {
            System.Diagnostics.Process.Start("Funlog.exe");
        }

        private void graf_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("graficador.exe");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFgonzalezZamoraFernando.exe");
        }

        public void Entrada()
        {

            try {
                x = double.Parse(textBox1.Text);//conversion
                y = double.Parse(textBox2.Text);
                fx=textBoxFx.Text;//ambos son cadena no necesita conversion
                fxy=textBox_fxy.Text;
            } catch { MessageBox.Show("Error de datos..."); }
            
        }
        public void Salida(double r)
        {
            listBox1.Items.Add(r);//escribiendo datos en el cuadro
            textBoxMensaje.Text=mensaje;
        }    

        
    }
}
