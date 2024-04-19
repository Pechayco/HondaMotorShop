using HondaModel;

namespace HondaDL
{
    public class UserData
    {
        List<User> userList = new List<User>();

        public UserData()
        {
            CreateUserData();
        }

        private void CreateUserData()
        {
            User userOne = new User { UserID = "Honda-2001", UserPass = "Honda2001" };
            userList.Add(userOne);

            User userTwo = new User { UserID = "Honda-2002", UserPass = "Honda2002" };
            userList.Add(userTwo);

            User userThree = new User { UserID = "Honda-2003", UserPass = "Honda2003" };
            userList.Add(userThree);

            User userFour = new User { UserID = "Honda-2004", UserPass = "Honda2004" };
            userList.Add(userFour);

            User userFive = new User { UserID = "Honda-2005", UserPass = "Honda2005" };
            userList.Add(userFive);


        }

        public User GetUser(string UserID, string UserPass)
        {
            User foundUser = new User();

            foreach (var users in userList)
            {
                if (UserID == users.UserID && UserPass == users.UserPass)
                {
                    foundUser = users;
                }
            }
            return foundUser;
        }
    }
}
