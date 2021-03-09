namespace IocUnity
{
    using System;
    using Unity;
    using Unity.Injection;

    class Program
    {
        static void Main(string[] args)
        {

            UnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>("LuxuryCar");

            container.RegisterType<Driver>("LuxuryCarDriver",
                new InjectionConstructor(container.Resolve<ICar>("LuxuryCar")));

            Driver driver1 = container.Resolve<Driver>();// injects BMW
            driver1.RunCar();

            Driver driver2 = container.Resolve<Driver>("LuxuryCarDriver");// injects Audi
            driver2.RunCar();

            Console.ReadLine();

        }
    }
}
