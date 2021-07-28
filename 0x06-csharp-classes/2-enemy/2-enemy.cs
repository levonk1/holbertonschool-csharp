using System;

namespace Enemies
{
    /// <summary>This class create a Zombie</summary>
    public class Zombie
    {
        /// <summary>This is a public field</summary>
        public int health;

        /// <summary>This is a constructor</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>This is a constructor that receives an argument and throw an exception. </summary>
        public Zombie(int value)
        {
            if (value >= 0)
                health = value;

            else
            {
                throw new System.ArgumentException("Health must be greater than or equal to 0");
            }
        }
    }
}
