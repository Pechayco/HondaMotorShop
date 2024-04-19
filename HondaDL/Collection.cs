using HondaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HondaDL
{
    public class Collection
    {
        List<MotorModel> motorsList = new List<MotorModel>();

        public  Collection()
        {
            Collections();
        }

        public void Collections()
        {
            MotorModel motorOne = new MotorModel
            {
                Model = "The New CLICK160 ",
                yearModel = 2022,
                Displacement = "157cc",
                Price = 122900,
                Stock = 65,
            };
            motorsList.Add(motorOne);

            MotorModel motorTwo = new MotorModel
            {
                Model = "AirBlade160",
                yearModel = 2022,
                Displacement = "157cc",
                Price = 125900,
                Stock = 79,
            };
            motorsList.Add(motorTwo);
            MotorModel motorThree = new MotorModel
            {
                Model = "The New PCX160",
                yearModel = 2024,
                Displacement = "157cc",
                Price = 131900,
                Stock = 100,
            };
            motorsList.Add(motorThree);
            MotorModel motorFour = new MotorModel
            {
                Model = "Honda CRF300 Rally",
                yearModel = 2024,
                Displacement = "286cc",
                Price = 300000,
                Stock = 96,
            };
            motorsList.Add(motorFour);
            MotorModel motorFive = new MotorModel
            {
                Model = "Honda Gold Wing 1800",
                yearModel = 2024,
                Displacement = "1,833cc",
                Price = 1880000,
                Stock = 100,
            };
                motorsList.Add(motorFive);

        }

        public List<MotorModel> Getmotorslist()
        {
            return motorsList;
        }
    }
}
