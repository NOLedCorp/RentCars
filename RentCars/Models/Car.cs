using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.Models
{
    class Car
    {
        public Car(int carId, string model, string description, string img, int bodyType, int fuelType, int passNum, double price)
        {
            CarId = carId;
            Model = model;
            Description = description;
            Photo = img;
            BodyType = (BodyTypes)bodyType;
            FuelType = (FuelTypes)fuelType;
            PassengersNumber = passNum;
            Price = price;
        }

        public int CarId { get; set; }

        /// <summary>
        /// Модель автомобиля
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Описание автомобиля
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Изображение автомобиля
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// Тип кузова
        /// 1 - Хэтчбек
        /// 2 - Кроссовер
        /// 3 - Минивен
        /// </summary>
        public BodyTypes BodyType { get; set; }

        /// <summary>
        /// Тип топлива
        /// 1 - Бензин
        /// 2 - Дизель
        /// </summary>
        public FuelTypes FuelType { get; set; }

        /// <summary>
        /// Количество пассажиров
        /// </summary>
        public int PassengersNumber { get; set; }

        /// <summary>
        /// Цена заказа
        /// </summary>
        public double Price { get; set; }

    }
}
