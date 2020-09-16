
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   
    class AssemblyLine
    {
        // El constructor usa una serie compleja de pasos
        // ingresamos los ingredientes que lleva un sandwich
        public void Assemble(SandwichBuilder sandwichBuilder)
        {
            sandwichBuilder.AddBread();
            sandwichBuilder.AddMeats();
            sandwichBuilder.AddCheese();
            sandwichBuilder.AddVeggies();
            sandwichBuilder.AddCondiments();
        }
    }


    /// La clase abstracta Builder

    abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        // Obtiene una instancia de sándwich
        public Sandwich Sandwich
        {
            get { return sandwich; }
        }

        // Métodos de construcción abstractos
        public abstract void AddBread();
        public abstract void AddMeats();
        public abstract void AddCheese();
        public abstract void AddVeggies();
        public abstract void AddCondiments();
    }


    /// Una clase de constructor donde ingresamos el tipo de sandwich

    class TurkeyClub : SandwichBuilder
    {
        public TurkeyClub()
        {
            sandwich = new Sandwich("Turkey Club");
        }

        public override void AddBread()
        {
            sandwich["bread"] = "12-Grain";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Turkey";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "Swiss";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "Lettuce, Tomato";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo";
        }
    }


    /// Una clase de constructor donde ingresamos el tipo de sandwich
    class BLT : SandwichBuilder
    {
        public BLT()
        {
            sandwich = new Sandwich("BLT");
        }

        public override void AddBread()
        {
            sandwich["bread"] = "Wheat";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Bacon";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "None";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "Lettuce, Tomato";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo, Mustard";
        }
    }






    ///Una clase de constructor donde ingresamos el tipo de sandwich
    class HamAndCheese : SandwichBuilder
    {
        public HamAndCheese()
        {
            sandwich = new Sandwich("Ham and Cheese");
        }

        public override void AddBread()
        {
            sandwich["bread"] = "White";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Ham";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "American";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "None";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo";
        }
    }

    /// el producto de la clase

    class Sandwich
    {
        private string _sandwichType;
        private Dictionary<string, string> _ingredients = new Dictionary<string, string>();

        // Constructor
        public Sandwich(string sandwichType)
        {
            this._sandwichType = sandwichType;
        }

        // Indexer
        public string this[string key]
        {
            get { return _ingredients[key]; }
            set { _ingredients[key] = value; }
        }
        //muestra los ingredientes del sandwich
        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Sandwich: {0}", _sandwichType);
            Console.WriteLine(" Bread: {0}", _ingredients["bread"]);
            Console.WriteLine(" Meat: {0}", _ingredients["meat"]);
            Console.WriteLine(" Cheese: {0}", _ingredients["cheese"]);
            Console.WriteLine(" Veggies: {0}", _ingredients["veggies"]);
            Console.WriteLine(" Condiments: {0}", _ingredients["condiments"]);
        }
    }
}