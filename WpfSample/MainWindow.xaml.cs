using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfSample.ViewModels;

namespace WpfSample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var text = new TextBoxViewModel { Left = 10, Top = 10, Width = 200, Height = 20, Text = "Hello" };
            var button = new ButtonViewModel 
            {
                Left = 90,
                Top = 120,
                Width = 100,
                Height = 20, 
                Text = "Click",
                Command = new RelayCommand(new Action(()=> MessageBox.Show(text.Text))),
            };

            this.DataContext = new List<ViewModelBase> { text, button};
        }
    }
}
