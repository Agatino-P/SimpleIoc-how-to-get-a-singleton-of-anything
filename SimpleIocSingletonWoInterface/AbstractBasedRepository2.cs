namespace SimpleIocSingletonWoInterface
{
    public class AbstractBasedRepository2 : IAbstractBasedRepository<Derived2>
    {
        public AbstractBasedRepository2()
        {
            "AbstractBasedRepository2.Constructor".DP();
        }

        public void TestMethod(string text)
        {
            Derived2 derived2 = new Derived2("I2", "T2");
            $"AbstractBasedRepository2 - text: {text} - {derived2.ToText()}".DP();
        }

    }
}
