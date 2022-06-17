using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using learning.FactoryMethod;
using learning.Adapter;
using learning.Decorator;
using learning.Proxy;
using learning.State;
using static learning.Observer_min.ObserverDeNincsIdomMegirniKulonOsztalyokba;
using static learning.Template_min.TemplateDeNincsIdomMegirniRendesen;
using static learning.Strategy.StrategyDeNincsIdoMegirniRendesen;
using static learning.Visitor_min.VisitorCsakNincsIdoMegirniRendesen;

namespace learning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Létrehozási tervezési minták:

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

            // Illesztő / adapter
            Robot R2D2 = new Robot("R2D2", 80000);
            Human R2D2wrapper = new Robot2Human(R2D2);
            Console.WriteLine("Neve: {0}", R2D2wrapper.GetName());
            Console.WriteLine("IQ-ja: {0}", R2D2wrapper.GetIQ());

            // Díszítő - decorator

            //Létrehozok egy objektumot ami örököl read-only fieldeket és overrideolja őket
            //hogy személyre szabott típus legyen.
            //Nekünk az Audi A5 örökölt mindent a VehicleBase-ből, Make,model,hirelaps,hireprice
            AudiA5 car = new AudiA5();
            Console.WriteLine("Alap Audi A5:\r\n");
            Console.WriteLine("Alap ár: {0}, alap tesztkörök száma: {1}\r\n\r\n", car.HirePrice, car.HireLaps);


            SpecialOffer offer = new SpecialOffer(car);
                         offer.Discount = 25;
                         offer.ExtraLaps = 2;

            Console.WriteLine("Speciális ajánlat:\r\n");
            Console.WriteLine("Különleges ajánlat ára: {0}, {1}$-ért\r\n\r\n", offer.HirePrice, offer.HireLaps);
            Hireable hire = new Hireable(car);
            hire.Hire("Bill");
            Hireable hire2 = new Hireable(offer);
            hire2.Hire("Jack");


            // Proxy

            // Készítünk egy helyettest és kérünk egy szolgáltatást.
            ProxyClass proxy = new ProxyClass();
            proxy.Request();



            //Viselkedési tervezési minták

            // State - állapot
            AudioPlayer player = new AudioPlayer(new StandbyState());
            player.PressPlay();
            player.PressAudioSource();
            player.PressPlay();
            player.PressPlay();
            player.PressAudioSource();
            player.PressPlay();
            player.PressAudioSource();


            // Megfigyelő – Observer

            // létrehozzuk a weatherData objektumot
            WeatherData weatherData = new WeatherData();
            // létrehozzuk a displayt és odaajuk neki a weatherData-t
            CurrentConditionsDisplay currentDisplay =
            new CurrentConditionsDisplay(weatherData);
            // új időjárási mérésértékek szimulálása
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            // Sablonmetódus – Template Method
            Ital tea = new Tea();
            Ital kávé = new Kávé();
            tea.Elkészít();  // a késői kötés miatt a Tea főz és édesít metódusa fut
            kávé.Elkészít(); // a késői kötés miatt a Kávé főz és édesít metódusa fut

            // Stratégia – Strategy
            KávéGép automata = new KávéGép();
            automata.KávéValasztás(new GyengeKávé());
            automata.KávéFőzés();
            automata.KávéValasztás(new ErősKávé());
            automata.KávéFőzés();
            automata.KávéValasztás(new NormalKávé());
            automata.KávéFőzés();

            // Látogató – Visitor (ágensalapú programozás tervezési minta)
            BFa fa = new Fa(5, new Levél(8), new Levél(3));
            SumVisitor sumv = new SumVisitor();
            MaxVisitor maxv = new MaxVisitor();
            fa.Accept(sumv);
            fa.Accept(maxv);
            Console.WriteLine("A fában lévő számok összege: {0}", sumv.Sum);
            Console.WriteLine("A fában lévő legnagyobb szám: {0}", maxv.Max);



            Console.ReadKey();



        }
   
}
}
