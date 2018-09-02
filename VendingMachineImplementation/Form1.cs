using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineImplementation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //COCA COLA WORK
        {
            Cashcounter c1 = new Cashcounter(0);
            c1.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//PEPSI WORK
        {
            Cashcounter c1 = new Cashcounter(1);
            c1.Show();
           
        }

        private void button3_Click(object sender, EventArgs e) //COFFEE WORK
        {
            Cashcounter c1 = new Cashcounter(4);
            c1.Show();
           
        }

        private void button4_Click(object sender, EventArgs e) //POPCORN WORK
        {
            Cashcounter c1 = new Cashcounter(3);
            c1.Show();
           
        }

        private void button6_Click(object sender, EventArgs e) //WATER BOTTLE WORK
        {
            Cashcounter c1 = new Cashcounter(5);
            c1.Show();
           
        }

        private void button7_Click(object sender, EventArgs e) //LAYS WORK
        {
            Cashcounter c1 = new Cashcounter(2);
            c1.Show();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
