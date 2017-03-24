using DevExpress.Mvvm;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApplication35
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class ViewModel : ViewModelBase
    {
        public string Value
        {
            get
            {
                return GetProperty(() => Value);
            }
            set
            {
                SetProperty(() => Value, value);
            }
        }
    }

    public class TextEditEx : TextEdit
    {
        protected override void OnDisplayTextChanged(string displayText)
        {
            base.OnDisplayTextChanged(displayText);
            BindableDisplayText = displayText;
        }


        public string BindableDisplayText
        {
            get { return (string)GetValue(BindableDisplayTextProperty); }
            set { SetValue(BindableDisplayTextProperty, value); }
        }

        public static readonly DependencyProperty BindableDisplayTextProperty =
            DependencyProperty.Register("BindableDisplayText", typeof(string), typeof(TextEditEx), null);


    }

}
