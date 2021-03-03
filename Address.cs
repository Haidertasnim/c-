using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_1
{
    public class Address
    {
        private string roadNo;
        private string houseNo;
        private string city;
        private string country;

        public Address(string roadNo, string houseNo, string city, string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;
        }
        public string Road
        {
            set{ roadNo = value; }
            get{ return roadNo; }
        }
        public string House
        {
            set { houseNo = value; }
            get { return houseNo; }
        }
        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public string Country
        {
            set { country = value; }
            get { return country; }
        }

        public string GetAddress()
        {
            return (roadNo+ "," +houseNo+ "," +city+ "," +country);
        }
    }
}
