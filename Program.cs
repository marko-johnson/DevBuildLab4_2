using System;

namespace Lab4_2_ObjectPractice
{
    class MenuItem
    {
        private int ID;
        private string Name;
        private string Description;
        private decimal Price;


        public MenuItem()
        {
            Console.WriteLine("\nI'm inside the DEFAULT constructor");
        }

        public MenuItem(int _ID, string _Name, string _Description, decimal _Price)
        {
            //ID = _ID;
            //Name = _Name;
            //Description = _Description;
            //Price = _Price;

            setID(_ID);
            setName(_Name);
            setDescription(_Description);
            setPrice(_Price);
            
        }

        //public MenuItem(int _ID, string _Name, string _Description, decimal _Price)
        //{
        //    ID = _ID;
        //    Name = _Name;
        //    Description = "";
        //    Price = _Price;
        //}

        // ID setter and getter
        public void setID(int _ID)
        {            
            ID = _ID;
        }

        public int getID()
        {
            return ID;
        }


        // Name setter and getter
        public void setName(string _Name)
        {
            Name = _Name;            
        }

        public string getName()
        {
            return Name;
        }



        // Description setter and getter
        public void setDescription (string _Description)
        {            
            Description = _Description;
        }

        public string getDescription()
        {
            return Description;
        }

        // Price setter and getter
        public void setPrice(decimal _Price)
        {
            if (_Price < 0.50m)
            {
                _Price = 0.50m;
            }

            if (_Price > 10.00m)
            {
                _Price = 10.00m;
            }
            Price = _Price;
        }

        public decimal getPrice()
        {
            return Price;
        }




        public override string ToString()
        {
            return $"\n-----------------ToString() Menu-----------------\nMenu Items\nID: {ID}\nName: {Name}\nDescription: {Description}\nPrice: ${Price}\n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MenuItem m1 = new MenuItem(1, "banana", "fruit", 7.40m);
            Console.WriteLine(m1.getID());
            Console.WriteLine(m1.getName());
            Console.WriteLine(m1.getDescription());
            Console.WriteLine(m1.getPrice());
            string menu = m1.ToString();
            Console.WriteLine(menu);



            MenuItem m2 = new MenuItem(2, "cheese", "dairy", 100.40m);                       
            Console.WriteLine(m2.getID());
            Console.WriteLine(m2.getName());
            Console.WriteLine(m2.getDescription());
            Console.WriteLine(m2.getPrice());
            string menu2 = m2.ToString();
            Console.WriteLine(menu2);



            MenuItem m3 = new MenuItem(2, "turkey", "poultry", 0.40m);
            Console.WriteLine(m3.getID());
            Console.WriteLine(m3.getName());
            Console.WriteLine(m3.getDescription());
            Console.WriteLine(m3.getPrice());
            string menu3 = m3.ToString();
            Console.WriteLine(menu3);



            MenuItem m4 = new MenuItem();
            Console.WriteLine(m4.getID());
            Console.WriteLine(m4.getName());
            Console.WriteLine(m4.getDescription());
            Console.WriteLine(m4.getPrice());
            string menu4 = m4.ToString();
            Console.WriteLine(menu4);
        }
    }
}
