using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfSample.ViewModels
{
    class ButtonViewModel : ViewModelBase
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public ICommand Command { get; set; }

    }
}
