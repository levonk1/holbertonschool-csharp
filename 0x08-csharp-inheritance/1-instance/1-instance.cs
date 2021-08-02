using System;

/// <summary> Create class obj.</summary>
class Obj
    {
        /// <summary>Function ti berify the inheritance</summary>
        /// <param name="obj">the object to get type</param>
        /// <returns>true or false</returns>
        public static bool IsInstanceOfArray(object obj)
        {
            bool check = typeof(Array).IsInstanceOfType(obj);
            return check;
        }
    }
