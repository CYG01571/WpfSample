using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSample.ViewModels
{
    class TextBoxViewModel : ViewModelBase
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

    }
}
