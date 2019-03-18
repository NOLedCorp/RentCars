using RentCars.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RentCars.Services
{
    class CarsService
    {
        private static List<Car> Cars { get; set; } = new List<Car>();

        public CarsService()
        {
        }

        public static List<Car> GetCars()
        {
            const string carsPath = "cars.xml";

            FileStream fs;
            
            if (File.Exists(carsPath))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Car>));
                fs = new FileStream(carsPath, FileMode.Open);
                Cars = (List<Car>)xs.Deserialize(fs);
                fs.Close();
            }
            else
            {
                var c = new Car(1, "VW CADDY 7 PAX", "Семиместный минивен, 1,4 литра, дизель. Специальные условия на длительную аренду.", "Resources/Caddy.jpg", 3, 2, 7, 70);
                Cars.Add(new Car(1, "VW CADDY 7 PAX", "Семиместный минивен, 1,4 литра, дизель. Специальные условия на длительную аренду.", "Resources/Caddy.jpg", 3, 2, 7, 70));
                Cars.Add(new Car(2, "VW Up", "Автомобиль с МКПП. Рабочий объем двигателя 1.0 литр. Кондционер, радио-CD, расход топлива 5л/100 км. В машину свободно входят четверо взрослых пассажира, 1 большая и 1 маленькая дорожные сумки", "Resources/Caddy.jpg", 3, 2, 7, 70));
                Cars.Add(new Car(1, "VW CADDY 7 PAX", "Семиместный минивен, 1,4 литра, дизель. Специальные условия на длительную аренду.", "Resources/Caddy.jpg", 3, 2, 7, 70));
                Cars.Add(new Car(1, "VW CADDY 7 PAX", "Семиместный минивен, 1,4 литра, дизель. Специальные условия на длительную аренду.", "Resources/Caddy.jpg", 3, 2, 7, 70));
                Cars.Add(new Car(1, "VW CADDY 7 PAX", "Семиместный минивен, 1,4 литра, дизель. Специальные условия на длительную аренду.", "Resources/Caddy.jpg", 3, 2, 7, 70));
                Cars.Add(new Car(1, "VW CADDY 7 PAX", "Семиместный минивен, 1,4 литра, дизель. Специальные условия на длительную аренду.", "Resources/Caddy.jpg", 3, 2, 7, 70));
                Cars.Add(new Car(1, "VW CADDY 7 PAX", "Семиместный минивен, 1,4 литра, дизель. Специальные условия на длительную аренду.", "Resources/Caddy.jpg", 3, 2, 7, 70));
                Cars.Add(new Car(1, "VW CADDY 7 PAX", "Семиместный минивен, 1,4 литра, дизель. Специальные условия на длительную аренду.", "Resources/Caddy.jpg", 3, 2, 7, 70));
            }

            return Cars;

        }
    }
}
