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
        public int health;
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
    }
}