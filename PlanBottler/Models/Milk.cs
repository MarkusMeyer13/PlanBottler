namespace PlanBottler.Models
{
    /// <summary>
    /// Milk.
    /// </summary>
    /// <seealso cref="PlanBottler.Models.NonAlcoholicDrink" />
    internal class Milk : NonAlcoholicDrink
    {
        /// <summary>
        /// Gets or sets the calcium Percentage.
        /// </summary>
        /// <value>
        /// The calcium Percentage.
        /// </value>
        public double CalciumPercentage { get; set; } = 0.1d;

        private double sugar;

        public double GetSugar()
        {
            return this.sugar;
        }

        public void SetSugar(double val)
        {
            this.sugar = val;
        }


    }
}
