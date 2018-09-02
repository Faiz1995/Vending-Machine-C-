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
    public partial class Cashcounter : Form
    {
        int check;
        public Cashcounter(int ch)
        {
            InitializeComponent();
                this.check=ch;

        }
        Cokecola ck = new Cokecola();
        Pepsi pep = new Pepsi();
        Chips cp = new Chips();
        Popcorn pp = new Popcorn();
        Coffee cf = new Coffee();
        Waterbottle wb = new Waterbottle();

        private void Cashcounter_Load(object sender, EventArgs e)
        {

        }
        int amount = 0;

        private void button2_Click(object sender, EventArgs e) //0$ button
        {
            amount = 0;
        }

        private void button3_Click(object sender, EventArgs e) // 1$ button
        {
            amount = 1;
        }

        private void button4_Click(object sender, EventArgs e)//2$ button
        {
            amount = 2;
        }

        private void button5_Click(object sender, EventArgs e)//5$ button
        {
            amount = 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //COCA COLA WORK
            if (check == 0)
            {
                ck.currstate = ck.Ttable(ck.currstate, amount, ck.coke);
                if (ck.currstate == ck.cokefinalstate && ck.cokecounter != 0)
                {
                    MessageBox.Show("Successful ,get your coke now from bottom ");
                    amount = 0;
                    ck.currstate = 0;
                    ck.cokecounter--;

                }
                else if (ck.cokecounter == 0)
                {
                    MessageBox.Show("Sorry No more cokes available");
                }
            }

            //PEPSI WORK
            else if (check == 1)
            {
                pep.currstate = pep.Ttable(pep.currstate, amount, pep.pepsi);
                if (pep.currstate == pep.pepsifinalstate && pep.pepsicounter != 0)
                {
                    MessageBox.Show("Successful ,get your Pepsi now from bottom ");
                    amount = 0;
                    pep.currstate = 0;
                    pep.pepsicounter--;

                }
                else if (pep.pepsicounter == 0)
                {
                    MessageBox.Show("Sorry No more Pepsi availabe");
                }
            }
            // CHIPS WORK
            else if (check == 2)
            {
                cp.currstate = cp.Ttable(cp.currstate, amount, cp.chips);
                if (cp.currstate == cp.Chipsfinalstate && cp.Chipscounter != 0)
                {
                    MessageBox.Show("Successful ,get your Chips now from bottom ");
                    amount = 0;
                    cp.currstate = 0;
                    cp.Chipscounter--;

                }
                else if (cp.Chipscounter == 0)
                {
                    MessageBox.Show("Say No more chips availabe");
                }
            }
            //POPCORN WORK
            else if (check == 3)
            {
                pp.currstate = pp.Ttable(pp.currstate, amount, pp.popcorn);
                if (pp.currstate == pp.Popcornfinalstate && pp.Popcorncounter != 0)
                {
                    MessageBox.Show("Successful ,get your Popcorn now from bottom ");
                    amount = 0;
                    pp.currstate = 0;
                    pp.Popcorncounter--;

                }
                else if (pp.Popcorncounter == 0)
                {
                    MessageBox.Show("Sorry No more Popcorn availabe");
                }

            }
            //COFFEE WORK
            else if (check == 4)
            {
                cf.currstate = cf.Ttable(cf.currstate, amount, cf.coffee);
                if (cf.currstate == cf.coffeefinalstate && cf.coffeecounter != 0)
                {
                    MessageBox.Show("Successful ,get your Coffee now from bottom ");
                    amount = 0;
                    cf.currstate = 0;
                    cf.coffeecounter--;

                }
                else if (cf.coffeecounter == 0)
                {
                    MessageBox.Show("Sorry No more Coffee availabe");
                }

            }
            //WATER BOTTLE WORK
            else if (check == 5)
            {
                wb.currstate = wb.Ttable(wb.currstate, amount, wb.Bottle);
                if (wb.currstate == wb.Bottlefinalstate && wb.Bottlecounter != 0)
                {
                    MessageBox.Show("Successful ,get your Water Bottle now from bottom ");
                    amount = 0;
                    wb.currstate = 0;
                    wb.Bottlecounter--;

                }
                else if (wb.Bottlecounter == 0)
                {
                    MessageBox.Show("Sorry No more  Bottle availabe");
                }
            }
        }
    }
}
