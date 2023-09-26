using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoCakesLib.model
{
    public class Cake
    {
        /*
         * instans fields
         */
        private int _id;
        private string _name;
        private string _description;
        private double _price;

        /*
         * properties
         */
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public double Price { get { return _price; } set { _price = value; } }

        /*
         * constructors
         */
        public Cake() { 
            _id = 0;
            _name = string.Empty;
            _description = string.Empty;
            _price = 0;
        }

        // public Cake(): this(0, string.Empty, string.Empty, 0) {}

        public Cake(int id, string name, string description, double price)
        {
            _id = id;
            _name = name;
            _description = description;
            _price = price;
        }


        /*
         * ToString
         */
        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Description)}={Description}, {nameof(Price)}={Price.ToString()}}}";
        }



    }
}
