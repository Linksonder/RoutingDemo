using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutinigDemo.ViewModel
{
    public class ViewModel2 : ViewModelBase
    {
        public string Name { get; set; }

        public ViewModel2()
        {
            Name = "Two";
        }
    }
}
