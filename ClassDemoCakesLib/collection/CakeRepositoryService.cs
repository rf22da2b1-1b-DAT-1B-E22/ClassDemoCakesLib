using ClassDemoCakesLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoCakesLib.collection
{
    public class CakeRepositoryService
    {
        /*
         * collection of cakes
         */

        private List<Cake> cakes;

        /*
         * Constructor
         */

        public CakeRepositoryService(bool MedTestData = false) { 
            cakes = new List<Cake>();

            if (MedTestData)
            {
                PopulateCakes();
            }
        }

        



        /*
         * Methods
         * 
         * CRUD etc.
         */

        public Cake Add(Cake cake)
        {
            cakes.Add(cake);

            return cake;
        }

        public Cake Delete(int id)
        {
            Cake cake = GetById(id); // can throw an exception

            cakes.Remove(cake);
            return cake;

        }

        public Cake Edit(int id, Cake cake)
        {
            Cake foundCake = GetById(id); // can throw an exception

            cakes[cakes.IndexOf(foundCake)] = cake;
            return cake;

        }

        public Cake GetById(int id)
        {
            Cake? cake = cakes.Find(c => c.Id == id);

            if (cake is null)
            {
                throw new KeyNotFoundException();
            }

            return cake;
        }


        public IEnumerable<Cake> GetAll()
        {
            return new List<Cake>(cakes);
        }








        /*
         * For test purpose - add testdata
         */
        public void PopulateCakes()
        {
            cakes.Clear();

            cakes.Add(new Cake(1, "Snegl", "wienerbrød med glasur", 23));
            cakes.Add(new Cake(2, "Kaj Kage", "tørkage grøn med kræm", 31));
            cakes.Add(new Cake(1, "Brunsviger", "gærbund godt med sukkerglasur", 26));
            cakes.Add(new Cake(1, "Croissant", "wienerbrød", 19));
            cakes.Add(new Cake(1, "Jordbærkage", "flødeskumskage med jordbær", 35));

        }



        /*
         * ToString
         */
        public override string ToString()
        {
            return $"{{String.join(', ', cakes)}}";
        }
    }
}
