using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broker
{
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void indiPersonButton_Click(object sender, EventArgs e)
        {
            Program.setClientType(Type.INDIVIDUAL);
            this.Hide();
            new Question1().ShowDialog();
        }

        private void legalEntButton_Click(object sender, EventArgs e)
        {
           Program.setClientType(Type.LEGENT);
            this.Hide();
            new QuestionForLegEnt().ShowDialog();
        }

        private void corpClientButton_Click(object sender, EventArgs e)
        {
            Program.setClientType(Type.CORPORATE);
            this.Hide();
            new Question1().ShowDialog();
        }

        private void Entrance_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();
            else if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
