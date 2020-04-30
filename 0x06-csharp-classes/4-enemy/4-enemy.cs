using System;

namespace Enemies
{
    /// <summary>
    /// Empty class
    /// </summary>
    public class Zombie
    {
        /// <summary> 
        /// Field that keeps track of the health
        /// </summary>
        private int health;
        /// <summary>
        /// Name Field
        /// </summary>
        private string name = "(No name)";
        /// <summary>
        /// Class Constructor
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        /// Overloading with a new class constructor
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                this.health = value;
            }
        }
        /// <summary>
        /// Retrives the value of health
        /// </summary>
        /// <returns>
        /// Health's value
        /// </returns>
        public int GetHealth() => (this.health);

        /// <summary>
        /// Property that retrieves and updates name
        /// </summary>
        public string Name
        {
            get
            {
                return(this.name);
            }
            set
            {
                name = value;
            }
        }
    }
}