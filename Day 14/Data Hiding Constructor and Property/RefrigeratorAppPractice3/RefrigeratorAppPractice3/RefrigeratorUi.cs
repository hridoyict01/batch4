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
         RefrigeratorCapacity refrigerator = new RefrigeratorCapacity();
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            refrigerator.MaxWeight = Convert.ToDouble(maxWeightTakeTextBox.Text);
            maxWeightTakeTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            int numberOfItems = Convert.ToInt16(itemTextBox.Text);
            double weight = Convert.ToDouble(weightTextBox.Text);
            double totalWeight = numberOfItems * weight;
            double result = refrigerator.RemainingWeight(totalWeight);
            if (result < 0)
            {
                MessageBox.Show("Weight overflow");
            }
            else
            {
                remainingWeightTextBox.Text = result.ToString();
                currentWeightTextBox.Text = refrigerator.CurrentWeight.ToString();
            }
            
            itemTextBox.Clear();
            weightTextBox.Clear();

        }
    }
}
