using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using learning.FactoryMethod;
using learning.Adapter;

namespace learning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton osztály, csak egy példánya lehet.
            SingletonClass s1 = SingletonClass.GetInstance();
            SingletonClass s2 = SingletonClass.GetInstance();
            Console.WriteLine(s1 == s2);

            ThreadSafeSingleton tss_1 = ThreadSafeSingleton.Instance;
            ThreadSafeSingleton tss_2 = ThreadSafeSingleton.Instance;
            Console.WriteLine(tss_1 == tss_2);

            // Prototípus
            Automobile prototype1 = new Sportscar("Porsche",200,300);
            AutoFactory factory = new AutoFactory();
            Automobile[] autos = factory.StartProduction(prototype1, 240, 10);
            foreach (var item in autos)
            {
                Console.WriteLine(item.Brand);
                Console.WriteLine(item.HorsePower);
            }

            // Gyártó metódus / factory method

            CertificationFactory[] certifications = new CertificationFactory[2];
            certifications[0] = new ActualCertificationFactory1();
            certifications[1] = new ActualCertificationFactory2();

            foreach (var item in certifications)
            {
                ICertification certificate = item.CreateCertification();
                certificate.Certificate();
            }

            // Szerkezeti tervezési minták:
            Robot R2D2 = new Robot("R2D2", 80000);
            Human R2D2wrapper = new Robot2Human(R2D2);
            Console.WriteLine("Neve: {0}", R2D2wrapper.GetName());
            Console.WriteLine("IQ-ja: {0}", R2D2wrapper.GetIQ());


            Console.ReadKey();
        }
   
}
}
