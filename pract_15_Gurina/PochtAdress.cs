using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract_15_Gurina
{
    public class PochtAdress
    {
        string Street { get; set; } // улица
        string City { get; set; } // город
        string PostalCode { get; set; } // почтовый индекс
        string Country { get; set; } // страна

        // конструктор для инициализации
        public PochtAdress(string street, string city, string postalCode, string country)
        {
            Street = street;
            City = city;
            PostalCode = postalCode;
            Country = country;
        }

        public void UpdatingAddres(string street, string city, string postalCode, string country)
        {
            Street = street;
            City = city;
            PostalCode = postalCode;
            Country = country;
        }

        public string ToString()
        {
            return $"{Street}, {City}, {PostalCode}, {Country}";
        }
    }
}
