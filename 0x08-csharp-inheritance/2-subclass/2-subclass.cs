using System;

/// <summary>Create an Obj.</summary>
class Obj
{
    /// <summary>Function to check a sub class</summary>
    /// <param name="derivedType">derived class to check</param>
    /// <param name="baseType">base class to make comparison</param>
    /// <returns> True if is a sub class or false if isn't</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}