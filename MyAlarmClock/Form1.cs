using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyAlarmClock
{
    public partial class Form1 : Form
    {
        DateTime timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Continue.Visible = false;
            Stop.Visible = true;
            timer1.Start();

            
        }

        private void minutes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SecondBack()
        {
            timer=timer.Subtract(new TimeSpan(0,0,1));
            CoutTimer.Text = timer.ToLongTimeString();
            if (timer.Hour == 0 && timer.Minute == 0 && timer.Second == 0)
            {
                
                string soundPath = Path.GetFullPath( @"..\..\Sounds\zzz.wav");
                Player.URL = soundPath;
                Player.Ctlcontrols.play();
                timer1.Stop();
                MainMenu();
                MessageBox.Show("The time is over", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Player.Ctlcontrols.stop();
                
            }

        }
        private void MainMenu()
        {
            CoutTimer.Visible = false;
            Finish.Visible = false;
            Stop.Visible = false;
            Continue.Visible = false;
            Start.Visible = true;
            hnum.Visible = true;
            mnum.Visible = true;
            snum.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            hnum.Value = 0;
            mnum.Value = 0;
            snum.Value = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            SecondBack();
        }

        private void Start_Click(object sender, EventArgs e)
        {
          timer=   new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,int.Parse(hnum.Value.ToString()), int.Parse(mnum.Value.ToString()), int.Parse(snum.Value.ToString()));
            if (timer.Hour != 0 || timer.Minute != 0 || timer.Second != 0)
            {
                
                timer1.Start();
                CoutTimer.Text = timer.ToLongTimeString();
                CoutTimer.Visible = true;
                Start.Visible = false;
                Finish.Visible = true;
                Stop.Visible = true;
                Start.Visible = false;
                hnum.Visible = false;
                mnum.Visible = false;
                snum.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            
            }
           
        }

      

        private void Finish_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MainMenu();
            
        }
        private void CoutTimer_Click(object sender, EventArgs e)
        {  }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Stop_Click(object sender, EventArgs e)
        {
            

            timer1.Stop();
            Stop.Visible = false;
            Continue.Visible = true;
            Finish.Visible = true;
        }
    }
}
