using NET.XF.Intro.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.XF.Intro.ViewModel
{
    public class UserViewModel
    {
        public ObservableCollection<User> Users;

        public UserViewModel()
        {
            LoadUsers();
        }

        private ObservableCollection<User> LoadUsers()
        {
            return Users = new ObservableCollection<User>()
            {
                new User()
                {
                    Name = "Anderson",
                    Password = "fiap"
                },
                new User()
                {
                    Name = "Aldo",
                    Password = "fiap"
                }
            };
        }
    }
}
