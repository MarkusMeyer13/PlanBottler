using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using PlanBottler.Models;

namespace PlanBottler
{
    internal class DrinkMachine
    {
        internal List<Drink> Drinks { get; set; }

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
                Price = 3.0d,
            };
            this.Drinks.Add(beer);
            this.Drinks.Add(beer);

            var whiteBeer = new Beer()
            {
                AlcoholByVolume = 5.9d,
                Name = "Riegele Weißbier",
                Volume = 0.5d,
                Price = 2.9d,
            };
            this.Drinks.Add(whiteBeer);
            this.Drinks.Add(whiteBeer);
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

            var tea = new Tea()
            {
                Name = "Pfefferminz",
                Volume = 0.25d,
                Price = 2.3d,
            };
            this.Drinks.Add(tea);
        }

        /// <summary>
        /// Gets the drink types.
        /// </summary>
        /// <returns>Ordered list of disctinct Drink Types.</returns>
        internal SortedList<string, string> GetDrinkTypes()
        {
            var types = new SortedList<string, string>
            {
                { "0", " - Please Select - " },
            };

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

        /// <summary>
        /// Gets the drink sub types.
        /// </summary>
        /// <param name="drinkType">Type of the drink.</param>
        /// <returns>Drink SubTypes.</returns>
        internal SortedList<string, string> GetDrinkSubTypes(string drinkType)
        {
            var subType = new SortedList<string, string>
            {
                { "0", " - Please Select - " },
            };
            foreach (var item in this.Drinks)
            {
                var drinkSubType = item.GetType().BaseType.FullName.Split('.')[2];
                if (drinkType == drinkSubType)
                {
                    var drink = item.GetType().FullName.Split('.')[2];

                    var drinkDisplayName = Regex.Replace(drink, "([a-z])([A-Z])", "$1 $2");
                    if (!subType.ContainsKey(drink))
                    {
                        subType.Add(drink, drinkDisplayName);
                    }
                }
            }

            return subType;
        }

        /// <summary>
        /// Gets the drink.
        /// </summary>
        /// <param name="drinkName">Name of the drink.</param>
        /// <returns>Drink.</returns>
        internal Drink GetDrink(string drinkName)
        {
            Drink drink = null;

            foreach (var item in this.Drinks)
            {
                if (item.Name.Equals(drinkName))
                {
                    drink = item;
                    break;
                }
            }

            return drink;
        }

        /// <summary>
        /// Gets the drinks.
        /// </summary>
        /// <param name="selectedDrinkSubType">Type of the drink.</param>
        /// <returns>Drinks.</returns>
        internal SortedList<string, string> GetDrinks(string selectedDrinkSubType)
        {
            var drinks = new SortedList<string, string>
            {
                { "0", " - Please Select - " },
            };
            foreach (var item in this.Drinks)
            {
                var drinkSubType = item.GetType().FullName.Split('.')[2];
                if (selectedDrinkSubType == drinkSubType && !drinks.ContainsKey(item.Name))
                {
                    drinks.Add(item.Name, item.Name);
                }
            }

            return drinks;
        }

        /// <summary>
        /// Gets the drink count.
        /// </summary>
        /// <param name="drink">The drink.</param>
        /// <param name="name">The name.</param>
        /// <returns>Drink count.</returns>
        internal SortedList<string, string> GetDrinkCount(string drink, string name)
        {
            Type type = Type.GetType($"PlanBottler.Models.{drink}");

            var drinkCount = new SortedList<string, string>();

            int count = 0;
            drinkCount.Add(count.ToString(), " - Please Select - ");
            foreach (var item in this.Drinks)
            {
                if (item.GetType().Equals(type) && item.Name.Equals(name))
                {
                    count++;
                    drinkCount.Add(count.ToString(), count.ToString());
                }
            }

            return drinkCount;
        }

        /// <summary>
        /// Gets the drink count.
        /// </summary>
        /// <param name="drinkName">Name of the drink.</param>
        /// <returns>Drink count.</returns>
        internal SortedList<string, string> GetDrinkCount(string drinkName)
        {
            var drinkCount = new SortedList<string, string>();

            int count = 0;
            drinkCount.Add(count.ToString(), " - Please Select - ");
            foreach (var item in this.Drinks)
            {
                if (item.Name.Equals(drinkName))
                {
                    count++;
                    drinkCount.Add(count.ToString(), count.ToString());
                }
            }

            return drinkCount;
        }
    }
}
