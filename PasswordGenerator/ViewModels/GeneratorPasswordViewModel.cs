using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PasswordGenerator.Commands;

namespace PasswordGenerator.ViewModels
{
    public class GeneratorPasswordViewModel : INotifyPropertyChanged
    {
        public GeneratorPasswordViewModel()
        {

        }

        #region Commands

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
