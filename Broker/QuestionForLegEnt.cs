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
    public partial class QuestionForLegEnt : Form
    {
        public QuestionForLegEnt()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, bool> tempDict = new Dictionary<string, bool>();
            tempDict.Add(feature1.Text, checkBox1.Checked);
            tempDict.Add(feature2.Text, checkBox2.Checked);
            tempDict.Add(feature3.Text, checkBox3.Checked);
            Program.setFeatures(tempDict);

            this.Hide();
            new Question1().ShowDialog();
        }
    }
}
