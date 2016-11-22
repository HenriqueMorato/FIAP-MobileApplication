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
    public class UserViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<User> Users;

        public UserViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
