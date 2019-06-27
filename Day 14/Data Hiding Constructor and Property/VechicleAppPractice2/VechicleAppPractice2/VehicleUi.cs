using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        Vehicle vehicle = new Vehicle();
        public VehicleUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            
            vehicle.Name = vehicleNameTextBox.Text;
            vehicle.RegNumber = regNoTextBox.Text;
            vehicleNameTextBox.Clear();
            regNoTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            int speed = Convert.ToInt32(speedTextBox.Text);
            vehicle.Speed.Add(speed);
            speedTextBox.Clear();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = vehicle.MinSpeed().ToString();
            maxSpeedTextBox.Text = vehicle.MaxSpeed().ToString();
            averageSpeedTextBox.Text = vehicle.AverageSpeed().ToString();
        }
    }
}
