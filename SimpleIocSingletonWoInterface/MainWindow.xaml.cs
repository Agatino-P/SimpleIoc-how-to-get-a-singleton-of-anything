using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleIocSingletonWoInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SimpleIoc.Default.Register<IWannaSingleton>( ()=> new WannaSingleton() );
        }

        private void tstButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"Button {DateTime.Now}");
            IWannaSingleton iws1 = SimpleIoc.Default.GetInstance<IWannaSingleton>();

        }
    }
}
