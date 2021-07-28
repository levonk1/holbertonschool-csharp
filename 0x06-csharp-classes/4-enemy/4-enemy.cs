using System;

namespace Enemies
{
    /// <summary>This class create a Zombie</summary>
    public class Zombie
    {
        /// <summary>Get or Set the health</summary>
        private int health;

        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class, with a value</summary>
        public Zombie(int value)
        {
            if (value >= 0)
                health = value;

            else
            {
                throw new System.ArgumentException("Health must be greater than or equal to 0");
            }
        }

        /// <summary>Set the name</summary>
        private string name = "(No name)";

        /// <summary>Get and Set the name</summary>
        public string Name
        {
            get => name;
            set => name = value;
        }

        /// <summary>Provides the health of a zombie </summary>
        public int GetHealth()
        {
            return health;
        }

    }
}
