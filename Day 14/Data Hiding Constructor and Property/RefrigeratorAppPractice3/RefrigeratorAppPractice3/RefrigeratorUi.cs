using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        private RefrigeratorCapacity refrigerator;
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            double maxWeight = Convert.ToDouble(maxWeightTakeTextBox.Text);
            refrigerator = new RefrigeratorCapacity(maxWeight);
            maxWeightTakeTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            int numberOfItems = Convert.ToInt16(itemTextBox.Text);
            double weight = Convert.ToDouble(weightTextBox.Text);
            double totalWeight = numberOfItems * weight;
            double reminingWeight = refrigerator.RemainingWeight(totalWeight);
            if (reminingWeight < 0)
            {
                MessageBox.Show("Weight overflow");
            }
            else
            {
                remainingWeightTextBox.Text = reminingWeight.ToString();
                currentWeightTextBox.Text = refrigerator.CurrentWeight.ToString();
            }
            
            itemTextBox.Clear();
            weightTextBox.Clear();

        }
    }
}
