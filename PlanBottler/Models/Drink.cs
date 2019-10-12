namespace PlanBottler.Models
{
    /// <summary>
    /// Drink.
    /// </summary>
    internal abstract class Drink
    {
        /// <summary>
        /// Gets or sets the volume.
        /// </summary>
        /// <value>
        /// The volume.
        /// </value>
        internal int Volume { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        internal string Name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        internal double Price { get; set; }
    }
}
