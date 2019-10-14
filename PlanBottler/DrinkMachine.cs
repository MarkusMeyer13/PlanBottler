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
                Name = "Riegele Weißbier",
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
    }
}
