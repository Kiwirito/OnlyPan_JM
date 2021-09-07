using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyPan_JM
{
    public partial class Empleado : Form

    {
        public int sumatoria1 = 0;
        public int cantidad1 = 0;
        public int sumatoria2 = 0;
        public int cantidad2 = 0;
        public int sumatoria3 = 0;
        public int cantidad3 = 0;
        public int sumtotal = 0;

        public Empleado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inicio de sesion exitosa");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            using (Form1 sf = new Form1())
            {
                this.Hide();
                sf.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel5.Visible == false & richTextBox1.Visible == false & label3.Visible == false)
            {
                panel5.Visible = true;
                richTextBox1.Visible = true;
                label3.Visible = true;
            }
            else
            {
                panel5.Visible = false;
                richTextBox1.Visible = false;
                label3.Visible = false;
            }

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Primero seleccionar un producto");
            }
            else
            {
                if (comboBox1.SelectedItem == "Pan milo - 1000$")
                {
                    sumatoria1 = sumatoria1 + 1000;
                    cantidad1 = cantidad1 + 1;
                }
                if (comboBox1.SelectedItem == "Pan leche - 2000$")
                {
                    sumatoria2 = sumatoria2 + 2000;
                    cantidad2 = cantidad2 + 1;
                }
                if (comboBox1.SelectedItem == "Pan dulce  - 3500$")
                {
                    sumatoria3 = sumatoria3 + 3500;
                    cantidad3 = cantidad3 + 1;
                }
                richTextBox1.Text = richTextBox1.Text + "\n" + "---------------------------------------------------------------------------------------------------------------------------------------" + "\n" + comboBox1.SelectedItem + "\n" + "---------------------------------------------------------------------------------------------------------------------------------------";
                comboBox1.Text = string.Empty;
              
            }





        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            label3.Text = "--- Ventas Totales ($) ---";
            richTextBox1.Clear();
            sumtotal = sumatoria1 + sumatoria2 + sumatoria3;
            richTextBox1.Text = richTextBox1.Text + "\n" + "---------------------------------------------------------------------------------------------------------------------------------------" + "\n" + "Pan de milo total vendidas = " + cantidad1 + " sumando un valor de " + sumatoria1 + "\n" + "---------------------------------------------------------------------------------------------------------------------------------------" + "\n" + "---------------------------------------------------------------------------------------------------------------------------------------" + "\n" + "Pan de leche total vendidas = " + cantidad2 + " sumando un valor de " + sumatoria2 + "\n" + "---------------------------------------------------------------------------------------------------------------------------------------" + "\n" + "---------------------------------------------------------------------------------------------------------------------------------------" + "\n" + "Pan de suave total vendidas = " + cantidad3 + " sumando un valor de " + sumatoria3 + "\n" + "---------------------------------------------------------------------------------------------------------------------------------------" + "\n" + "---------------------------------------------------------------------------------------------------------------------------------------" + "\n" + "Total cantidad = " + sumtotal + " $"+ "\n" + "---------------------------------------------------------------------------------------------------------------------------------------";
        }
    }
}
