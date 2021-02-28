using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using PasswordGenerator.Commands;

namespace PasswordGenerator.ViewModels
{
    public class GeneratorPasswordViewModel : INotifyPropertyChanged
    {
        public GeneratorPasswordViewModel()
        {
            CloseAppCommand = new RelayCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);
        }

        #region Commands

        public ICommand CloseAppCommand { get; }
        private void OnCloseAppCommandExecuted(object parametr) 
        {
            Application.Current.Shutdown();
        }
        private bool CanCloseAppCommandExecute(object parametr) => true;

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
