using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SOLID_CarSelection_App
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Business.NormalCar ncar = new Business.NormalCar();
            Business.HybridCar hcar = new Business.HybridCar();
            Business.ElecricCar ecar = new Business.ElecricCar();

            ncar.viewcar();
            ncar.fuelconsumption();
            hcar.fuelconsumption();
            ecar.fuelconsumption();

            View view = new View();
            view.Show();
        }
    }
}
