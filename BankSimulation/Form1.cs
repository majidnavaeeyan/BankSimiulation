using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Declare the Bajes
        Baje oBaje01 = new Baje(false, 1, "Ali Alizadeh");
        Baje oBaje02 = new Baje(false, 2, "Maryam Razavi");
        Baje oBaje03 = new Baje(false, 3, "Hassan Hashemi");
        Baje oBaje04 = new Baje(false, 4, "Majid Navaeeyan");



        private void Form1_Load(object sender, EventArgs e)
        {
            oBaje01.Status = false;
            oBaje02.Status = false;
            oBaje03.Status = false;
            oBaje04.Status = false;

            StateBaje01.BackColor = Color.Blue;
            StateBaje02.BackColor = Color.Blue;
            StateBaje03.BackColor = Color.Blue;
            StateBaje04.BackColor = Color.Blue;
        }


        int MoshtariID = 1;
        Queue<Moshtari> Qmoshtaris = new Queue<Moshtari>();
        private void getMoshtari_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            getMoshtari.Interval = random.Next(15000);
            Moshtari oMoshtari = new Moshtari(++MoshtariID);
            Qmoshtaris.Enqueue(oMoshtari);
            label2.Text = Qmoshtaris.Count.ToString();
        }


        CancellationTokenSource tokenSource = new CancellationTokenSource();

        private async void timerBaje01_Tick(object sender, EventArgs e)
        {

            if ((oBaje01.Status == false) && (Qmoshtaris.Count > 0)) //yani mitoone javab bede
            {
                oBaje01.Status = true;
                StateBaje01.BackColor = Color.Red;
                Random random = new Random();
                timerBaje01.Interval = random.Next(15000);
                Moshtari MyMoshtari = Qmoshtaris.Dequeue();
                label2.Text = Qmoshtaris.Count.ToString();
                label3.Text = ((MyMoshtari.MoshtariID)).ToString();
                //MessageBox.Show("Test");
                //System.Threading.Thread.Sleep(timerBaje01.Interval);
                await Task.Delay(timerBaje01.Interval, tokenSource.Token);
                oBaje01.Status = false;
                StateBaje01.BackColor = Color.Blue;
            }
        }

        private async void timerBaje02_Tick(object sender, EventArgs e)
        {
            if ((oBaje02.Status == false) && (Qmoshtaris.Count > 0)) //yani mitoone javab bede
            {
                oBaje02.Status = true;
                StateBaje02.BackColor = Color.Red;
                Random random = new Random();
                timerBaje02.Interval = random.Next(15000);
                Moshtari MyMoshtari = Qmoshtaris.Dequeue();
                label2.Text = Qmoshtaris.Count.ToString();
                label4.Text = ((MyMoshtari.MoshtariID)).ToString();
                //MessageBox.Show("Test");
                //System.Threading.Thread.Sleep(timerBaje02.Interval);
                await Task.Delay(timerBaje02.Interval, tokenSource.Token);
                oBaje02.Status = false;
                StateBaje02.BackColor = Color.Blue;
            }
        }

        private async void timerBaje03_Tick(object sender, EventArgs e)
        {
            if ((oBaje03.Status == false) && (Qmoshtaris.Count > 0)) //yani mitoone javab bede
            {
                oBaje03.Status = true;
                StateBaje03.BackColor = Color.Red;
                Random random = new Random();
                timerBaje03.Interval = random.Next(15000);
                Moshtari MyMoshtari = Qmoshtaris.Dequeue();
                label2.Text = Qmoshtaris.Count.ToString();
                label5.Text = ((MyMoshtari.MoshtariID)).ToString();
                //MessageBox.Show("Test");
                //System.Threading.Thread.Sleep(timerBaje03.Interval);
                await Task.Delay(timerBaje03.Interval, tokenSource.Token);
                oBaje03.Status = false;
                StateBaje03.BackColor = Color.Blue;
            }
        }

        private async void timerBaje04_Tick(object sender, EventArgs e)
        {
            if ((oBaje04.Status == false) && (Qmoshtaris.Count > 0)) //yani mitoone javab bede
            {
                oBaje04.Status = true;
                StateBaje04.BackColor = Color.Red;
                Random random = new Random();
                timerBaje04.Interval = random.Next(15000);
                Moshtari MyMoshtari = Qmoshtaris.Dequeue();
                label2.Text = Qmoshtaris.Count.ToString();
                label6.Text = ((MyMoshtari.MoshtariID)).ToString();
                //MessageBox.Show("Test");
                //System.Threading.Thread.Sleep(timerBaje04.Interval);
                await Task.Delay(timerBaje04.Interval, tokenSource.Token);
                oBaje04.Status = false;
                StateBaje04.BackColor = Color.Blue;
            }
        }
    }
}
