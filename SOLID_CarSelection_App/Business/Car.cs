using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SOLID_CarSelection_App.Business
{

    public abstract class iCar
    {

        string Make;
        string Model;
        int Year;
        string Color;
        int Milage;

        public void viewcar()
        {
            MessageBox.Show("ViewCar");
        }

        public abstract void fuelconsumption();

    }

    public class HybridCar : iCar
    {
        public override void fuelconsumption()
        {
            MessageBox.Show("Hybridcar");
        }
    }

    public class ElecricCar : iCar
    {
        public override void fuelconsumption()
        {
            MessageBox.Show("ElecricCar");
        }
    }

    public class NormalCar : iCar
    {
        public override void fuelconsumption()
        {
            MessageBox.Show("NormlCar");
        }
    }
}


