using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfSample.Common;

namespace WpfSample.ViewModels
{
    class ViewModelBase : BindableBase
    {
        private int left;
        public int Left
        {
            get { return left; }
            set { SetProperty(ref left, value); }
        }

        private int top;
        public int Top
        {
            get { return top; }
            set { SetProperty(ref top, value); }
        }

        private int width;
        public int Width
        {
            get { return width; }
            set { SetProperty(ref width, value); }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set { SetProperty(ref height, value); }
        }

    }
}
