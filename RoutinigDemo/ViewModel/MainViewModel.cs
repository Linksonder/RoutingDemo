using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Controls;
using System.Windows.Input;
using System;
using System.Collections.Generic;

namespace RoutinigDemo.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public UserControl CurrentView { get; set; }

        public ICommand SetViewCommand { get; set; }

        private IDictionary<string, Type> _views;

        public MainViewModel()
        {
            SetViewCommand = new RelayCommand<string>(SetView);
            _views = new Dictionary<string, Type>();
            _views.Add("1", typeof(UserControl1));
            _views.Add("2", typeof(UserControl2));

            SetView("2");
        }

        private void SetView(string viewName)
        {
            this.CurrentView = (UserControl) Activator.CreateInstance(_views[viewName]);
            RaisePropertyChanged("CurrentView");
        }
    }
}