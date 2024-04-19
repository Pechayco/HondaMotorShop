using System;
using HondaModel;
using HondaDL;

namespace HondaBL
{
    public class UserServices
    {
        public bool VerifyUser(string UserID, string UserPass)
        {
            UserData users = new UserData();
            var result = users.GetUser(UserID, UserPass);

            return result.UserID != null ? true : false;
        }

        public List<MotorModel> motorcollect = new List<MotorModel>();
        public List<MotorModel> GetMotors()
        {
            Collection callmotor = new Collection();
            return callmotor.Getmotorslist();
        }

        public void addCar(MotorModel motors)
        {
            motorcollect.Add(motors);
        }
        }
    }


