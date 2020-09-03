using GalaSoft.MvvmLight.Ioc;
using System;
using System.Windows;

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
            SimpleIoc.Default.Register<IWannaSingleton>(() => new WannaSingleton());

            SimpleIoc.Default.Register<IParametricConstructor>(() => new ParametricConstructor(DateTime.Now.ToString()));

            SimpleIoc.Default.Register<IRepository<Entity1, IEntity>>(() => new Repository1("Repository1<Entity1>"));
            SimpleIoc.Default.Register<IRepository<Entity2, IEntity>>(() => new Repository2("Repository2<Entity2>"));

            SimpleIoc.Default.Register<IAbstractBasedRepository<Derived1>>(() => new AbstractBasedRepository1());
            SimpleIoc.Default.Register<IAbstractBasedRepository<Derived2>>(() => new AbstractBasedRepository2());

            SimpleIoc.Default.Register<IFunctionRepository<Entity1>>(() => new FunctionRepository1((i, t) => new Entity1(i, t)));
            SimpleIoc.Default.Register<IFunctionRepository<Entity2>>(() => new GenericFunctionRepository<Entity2>((i, t) => new Entity2(i, t)));
        }

        private void tstButton1_Click(object sender, RoutedEventArgs e)
        {
            "Within Button 1 Click".DP();
            IWannaSingleton iws = SimpleIoc.Default.GetInstance<IWannaSingleton>();
            iws.PrintToDebug("Invoked from button");
        }

        private void tstButton2_Click(object sender, RoutedEventArgs e)
        {
            "Within Button 2 Click".DP();
            IParametricConstructor ipc = SimpleIoc.Default.GetInstance<IParametricConstructor>();
        }

        private void tstButton3_Click(object sender, RoutedEventArgs e)
        {
            IRepository<Entity1, IEntity> rep1 = SimpleIoc.Default.GetInstance<IRepository<Entity1, IEntity>>();
            IRepository<Entity2, IEntity> rep2 = SimpleIoc.Default.GetInstance<IRepository<Entity2, IEntity>>();
        }

        private void tstButton4_Click(object sender, RoutedEventArgs e)
        {
            IAbstractBasedRepository<Derived1> abr1 = SimpleIoc.Default.GetInstance<IAbstractBasedRepository<Derived1>>();
            abr1.TestMethod("uno");
            IAbstractBasedRepository<Derived2> abr2 = SimpleIoc.Default.GetInstance<IAbstractBasedRepository<Derived2>>();
            abr2.TestMethod("due");

        }

        private void tstButton5_Click(object sender, RoutedEventArgs e)
        {
            IFunctionRepository<Entity1> fr1 = SimpleIoc.Default.GetInstance<IFunctionRepository<Entity1>>();
            fr1.Add("frI1", "frT1");
            IFunctionRepository<Entity2> gfr2 = SimpleIoc.Default.GetInstance<IFunctionRepository<Entity2>>();
            gfr2.Add("gfrI2", "gfrT2");
        }
    }
}
