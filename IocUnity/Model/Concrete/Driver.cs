using System;
using Unity;

namespace IocUnity
{
    public class Driver
    {
        private ICar _car;

        [InjectionConstructor] //Driversınıf iki kurucu içeriyor. Bu nedenle, sınıfı [InjectionConstructor]çözerken hangi kurucunun çağrılacağını belirtmek için niteliği kullandık Driver.
        public Driver(ICar car)
        {
            _car = car;
        }

        public Driver(string name)
        {
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile", _car.GetType().Name, _car.Run());
        }


    }
}
