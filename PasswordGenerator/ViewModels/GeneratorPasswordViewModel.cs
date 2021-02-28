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
            MinAppCommand = new RelayCommand(OnMinAppCommandExecuted, CanMinAppCommandExecute);
        }

        #region Commands

        #region Close window command
        public ICommand CloseAppCommand { get; }
        private void OnCloseAppCommandExecuted(object parametr)
        {
            Application.Current.Shutdown();
        }
        private bool CanCloseAppCommandExecute(object parametr) => true;
        #endregion

        #region Minimize window command
        public ICommand MinAppCommand { get; }
        private void OnMinAppCommandExecuted(object parametr)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        private bool CanMinAppCommandExecute(object parametr) => true;
        #endregion

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
