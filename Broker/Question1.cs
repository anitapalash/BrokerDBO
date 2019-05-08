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
    public partial class Question1 : Form
    {
        public Question1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (rate1.SelectedItem == null || rate2.SelectedItem == null ||
                rate3.SelectedItem == null || rate4.SelectedItem == null ||
                rate5.SelectedItem == null || rate6.SelectedItem == null ||
                rate7.SelectedItem == null || rate8.SelectedItem == null || 
                rate9.SelectedItem == null)
            {
                MessageBox.Show("Вы оценили не все критерии", "Ошибка",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                //давать пользователю доделать недоделанное
                //сейчас возникает ошибка
            }

            Dictionary<string, int> tempDict = new Dictionary<string, int>();
            tempDict.Add(crit1.Text, int.Parse(rate1.SelectedItem.ToString()));
            tempDict.Add(crit2.Text, int.Parse(rate2.SelectedItem.ToString()));
            tempDict.Add(crit3.Text, int.Parse(rate3.SelectedItem.ToString()));
            tempDict.Add(crit4.Text, int.Parse(rate4.SelectedItem.ToString()));
            tempDict.Add(crit5.Text, int.Parse(rate5.SelectedItem.ToString()));
            tempDict.Add(crit6.Text, int.Parse(rate6.SelectedItem.ToString()));
            tempDict.Add(crit7.Text, int.Parse(rate7.SelectedItem.ToString()));
            tempDict.Add(crit8.Text, int.Parse(rate8.SelectedItem.ToString()));
            tempDict.Add(crit9.Text, int.Parse(rate9.SelectedItem.ToString()));

            Program.setCriterias(tempDict);
            this.Hide();
            new Question2().ShowDialog();
        }
    }
}
