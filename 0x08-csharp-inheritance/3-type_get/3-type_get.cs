using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        TypeInfo myInfo = myObj.GetType().GetTypeInfo();
        Console.WriteLine("{0} Properties:", myInfo.Name);
        foreach (PropertyInfo myProp in myInfo.GetProperties())
            Console.WriteLine("{0}", myProp.Name);
        Console.WriteLine("{0} Methods:", myInfo.Name);
        foreach (MethodInfo myMet in myInfo.GetMethods())
            Console.WriteLine("{0}", myMet.Name);

    }
}