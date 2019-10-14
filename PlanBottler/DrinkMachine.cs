using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using PlanBottler.Models;

namespace PlanBottler
{
    internal class DrinkMachine
    {
        public List<Drink> Drinks { get; set; }

        /// <summary>
        /// Fills this instance.
        /// </summary>
        internal void Fill()
        {
            this.Drinks = new List<Drink>();

            var beer = new Beer()
            {
                AlcoholByVolume = 5.7d,
                Name = "Augustiner Hell",
                Volume = 0.5d,
            };
            this.Drinks.Add(beer);

            var whiteBeer = new Beer()
            {
                AlcoholByVolume = 5.9d,
                Name = "Riegele Weißbier",
                Volume = 0.5d,
            };
            this.Drinks.Add(whiteBeer);

            var whiteWine = new Wine()
            {
                AlcoholByVolume = 9.4d,
                Name = "Riessling",
                Volume = 0.75d,
            };
            this.Drinks.Add(whiteWine);

            var organgeJuice = new Juice()
            {
                Name = "Orange Juice",
                Volume = 0.75d,
            };
            this.Drinks.Add(organgeJuice);
        }

        /// <summary>
        /// Gets the drink types.
        /// </summary>
        /// <returns>Ordered list of disctinct Drink Types.</returns>
        internal SortedList<string, string> GetDrinkTypes()
        {
            SortedList<string, string> types = new SortedList<string, string>();
            types.Add("-1", " - Please Select - ");
            foreach (var item in this.Drinks)
            {
                var drinkType = item.GetType().BaseType.FullName.Split('.')[2];
                var drinkTypeDisplayName = Regex.Replace(drinkType, "([a-z])([A-Z])", "$1 $2");
                if (!types.ContainsKey(drinkType))
                {
                    types.Add(drinkType, drinkTypeDisplayName);
                }
            }

            return types;
        }

        internal SortedList<string, string> GetDrinkSubTypes(string drinkType)
        {
            SortedList<string, string> types = new SortedList<string, string>();
            types.Add("-1", " - Please Select - ");
            foreach (var item in this.Drinks)
            {
                var drinkSubType = item.GetType().BaseType.FullName.Split('.')[2];
                if (drinkType == drinkSubType)
                {
                    var drink = item.GetType().FullName.Split('.')[2];

                    var drinkDisplayName = Regex.Replace(drink, "([a-z])([A-Z])", "$1 $2");
                    if (!types.ContainsKey(drink))
                    {
                        types.Add(drink, drinkDisplayName);
                    }
                }
            }

            return types;
        }

        /// <summary>
        /// Gets the drinks.
        /// </summary>
        /// <param name="drinkType">Type of the drink.</param>
        /// <returns>Drinks.</returns>
        internal object GetDrinks(string drinkType)
        {
            SortedList<string, string> drinks = new SortedList<string, string>();
            drinks.Add("-1", " - Please Select - ");
            foreach (var item in this.Drinks)
            {
                var drinkSubType = item.GetType().FullName.Split('.')[2];
                if (drinkType == drinkSubType)
                {
                    drinks.Add(item.Name, item.Name);
                }
            }

            return drinks;
        }
    }
}
