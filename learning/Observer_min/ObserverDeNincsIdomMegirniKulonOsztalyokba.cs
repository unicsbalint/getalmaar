using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.Observer_min
{
    class ObserverDeNincsIdomMegirniKulonOsztalyokba
    {
        public interface ISubject
        {
            // observer regisztrálásra
            void RegisterObserver(IObserver o);
            // observer törlésre
            void RemoveObserver(IObserver o);
            // meghívódik, hogy értesítse az megfigyelőket
            // amikor a Subject állapota megváltozik
            void NotifyObservers();
        }
        public interface IObserver
        {
            // értékék amiket megkapnak az observerek a Subjecttől, push-os megoldás
            void Update(float temp, float humidity, float pressure);
        }
        public interface IDisplayElement
        {
            // megjelenítés
            void Display();
        }
        // implementáljuk a Subject interfészt
        public class WeatherData : ISubject
        {
            // hozzáadunk egy listát amiben observereket tárolunk
            private List<IObserver> observers;
            private float temperature;
            private float humidity;
            private float pressure;
            public WeatherData()
            {
                // létrehozzuk az observereket tároló listát
                observers = new List<IObserver>();
            }
            public void RegisterObserver(IObserver o)
            {
                // amikor egy observer regisztrál, egyszerűen hozzáadjuk a listához
                observers.Add(o);
            }
            public void RemoveObserver(IObserver o)
            {
                // amikor egy observer kéri a törlését, egyszerűen töröljük a listából
                int i = observers.IndexOf(o);
                if (i >= 0)
                {
                    observers.Remove(o);
                }
            }
            // itt szólunk az observereknek az állapotról
            // mivel mind observerek, van Update() metódusuk, így tudjuk őket értesíteni
            public void NotifyObservers()
            {
                for (int i = 0; i < observers.Count; i++)
                {
                    IObserver observer = (IObserver)observers.ElementAt(i);
                    observer.Update(temperature, humidity, pressure); // ez push-os
                                                                      // observer.Update(this); // ez pull-os
                }
            }
            // amikor a Weather Station-től megkapjuk a frissített értékeket,
            //értesítjük az observereket
            public void MeasurementsChanged()
            {
                NotifyObservers();
            }
            // értékek beállítása hogy tesztelhessük a megjelenítést
            public void SetMeasurements(float temperature, float humidity, float pressure)
            {
                this.temperature = temperature;
                this.humidity = humidity;
                this.pressure = pressure;
                MeasurementsChanged();
            }
            // egyéb metódusok
        }
        // a display implementálja az Observert,
        //így fogadhat változásokat a WeatherData objektumtól
        // továbbá implementálja a DisplayElement-et, mivel
        //minden display element-nek implementálnia kell ezt az interfészt
        public class CurrentConditionsDisplay : IObserver, IDisplayElement
        {
            private float temperature;
            private float humidity;
            private ISubject weatherData;
            // a konstruktor megkapja a weatherData objektumot
            // (a Subject) és arra használjuk, hogy
            // a display-t observerként regisztráljuk
            public CurrentConditionsDisplay(ISubject weatherData)
            {
                this.weatherData = weatherData;
                weatherData.RegisterObserver(this);
            }
            // amikor az Update() meghívódik, mentjük a temperature-t és a humidity-t
            // majd meghívjuk a Display()-t
            public void Update(float temperature, float humidity, float pressure)
            {
                this.temperature = temperature;
                this.humidity = humidity;
                Display();
            }
            // Megjelenítjük a legújabb eredményeket
            public void Display()
            {
                Console.WriteLine("Current conditions: " + temperature + "F degrees and "
               + humidity + "% humidity");
            }
        }
        public class WeatherStation
        {
        }
    }
}
