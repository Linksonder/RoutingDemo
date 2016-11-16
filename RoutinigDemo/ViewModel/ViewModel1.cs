using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutinigDemo.ViewModel
{
    public class ViewModel1 : ViewModelBase
    {
        public string Name { get; set; }

        public ViewModel1()
        {
            Name = "One";
        }
    }
}
