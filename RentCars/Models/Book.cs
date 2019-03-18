using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.Models
{
    class Book
    {
        public int BookId { get; set; }

        /// <summary>
        /// Дата начала аренды
        /// </summary>
        public DateTime DateStart { get; set; }

        /// <summary>
        /// Дата конца аренды
        /// </summary>
        public DateTime DateFinish { get; set; }

        /// <summary>
        /// Имя арендатора
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Email арендатора
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Телефон арендатора
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Сумма заказа
        /// </summary>
        public decimal Sum { get; set; }

        /// <summary>
        /// Арендуемый автомобиль
        /// </summary>
        public Car Car { get; set; }

    }
}
