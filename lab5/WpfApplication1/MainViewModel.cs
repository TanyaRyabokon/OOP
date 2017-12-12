using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace WpfApplication1
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region Implementation of INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, args);
        }
        #endregion
    }

    public class DelegateCommand : ICommand
    {
        public delegate void ICommandOnExecute(object parameter);
        public delegate bool ICommandOnCanExecute(object parameter);

        private ICommandOnExecute _execute;
        private ICommandOnCanExecute _canExecute;

        public DelegateCommand(ICommandOnExecute onExecuteMethod, ICommandOnCanExecute onCanExecuteMethod)
        {
            _execute = onExecuteMethod;
            _canExecute = onCanExecuteMethod;
        }

        #region ICommand Members

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }

        #endregion
    }

    public class MainViewModel : ViewModelBase
    {
        private DelegateCommand exitCommand;

        #region Constructor

        public static AstBodiesModel Bodies { get; set; }
        public string BodyNameToAdd { get; set; }
        public float BodyWeightToAdd { get; set; }
        public float BodyXCoord { get; set; }
        public float BodyYCoord { get; set; }
        public float BodyZCoord { get; set; }
        public AstronomicalBody SelectedItem { get; set; }

        public MainViewModel()
        {
            Bodies = AstBodiesModel.Current;
        }

        #endregion

        public ICommand ExitCommand
        {
            get
            {
                if (exitCommand == null)
                {
                    exitCommand = new DelegateCommand(Exit, CanExecuteCommand1);
                }
                return exitCommand;
            }
        }

        private void Exit(object parameter)
        {
            Application.Current.Shutdown();
        }


        public bool CanExecuteCommand1(object parameter)
        {
            return true;
        }

        private ICommand _AddBody;
        public ICommand AddBody
        {
            get
            {
                if (_AddBody == null)
                {
                    _AddBody = new DelegateCommand(ExecuteCommand1, CanExecuteCommand1);

                }

                return _AddBody;
            }
        }

        public void ExecuteCommand1(object parameter)
        {
            BodyNameToAdd.Trim();

            StringBuilder SB = new StringBuilder();
            if (BodyNameToAdd == "")
            {
                SB.Remove(0, SB.Length);
                SB.Append("Please type in a name for the body.");
                throw new ArgumentException(SB.ToString());
            }

            if (BodyNameToAdd.Length < 3)
            {
                SB.Remove(0, SB.Length);
                SB.Append(" Name must be longer than 3 characters");
                throw new ArgumentException(SB.ToString());
            }
            if (BodyWeightToAdd < 0)
            {
                SB.Remove(0, SB.Length);
                SB.Append("Body weight must be greather than 0");
                SB.Append("Please give a valid weight");
                throw new ArgumentException(SB.ToString());
            }
            if (BodyXCoord < 0)
            {
                SB.Remove(0, SB.Length);
                SB.Append("Coordinate x must be greather than 0");
                SB.Append("Please give a valid weight");
                throw new ArgumentException(SB.ToString());
            }
            if (BodyYCoord < 0)
            {
                SB.Remove(0, SB.Length);
                SB.Append("Coordinate y must be greather than 0");
                SB.Append("Please give a valid weight");
                throw new ArgumentException(SB.ToString());
            }
            if (BodyZCoord < 0)
            {
                SB.Remove(0, SB.Length);
                SB.Append("Coordinate z must be greather than 0");
                SB.Append("Please give a valid weight");
                throw new ArgumentException(SB.ToString());
            }

            Bodies.AddBody(BodyNameToAdd,
                BodyWeightToAdd, BodyXCoord, BodyYCoord, BodyZCoord);
        }        
    }
}
