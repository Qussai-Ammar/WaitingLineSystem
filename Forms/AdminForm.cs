using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaitingLineSystem.Forms;

namespace WaitingLineSystem
{
    public partial class AdminForm : Form
    {
        Counter counter = new Counter();

        public AdminForm()
        {
            InitializeComponent();
            var smartLine = SmartLine.Instance;

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void CounterInfo_Click(object sender, EventArgs e)
        {
            counter.Show();

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            SmartLine.Instance.NextTurn();
            ServingTurn.Text = SmartLine.Instance.GetTurn().ToString();

            //Updating On Waiting Value
            OnWaiting.Text = SmartLine.Instance.Total().ToString();

            //Updating Counter 
            try
            {
                counter.Close();
                counter = new Counter();
                counter.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open Counter");
                
            }
            
            

        }

        private void OnWaiting_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            SmartLine.Instance.ResetLine();
            OnWaiting.Text = "0";
        }
    }
}
