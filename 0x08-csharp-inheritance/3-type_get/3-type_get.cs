using System;
using System.Reflection;

/// <summary> Object Class </summary>
class Obj
{
    /// <summary> Prints the names of the available properties and methods of an object.</summary>
    /// <returns> Nothing </returns>
    public static void Print(object myObj)
    {
        var objInfo = myObj.GetType().GetTypeInfo();

        // Properties Info
        PropertyInfo[] propertiesInfo = objInfo.GetProperties();
        System.Console.WriteLine("{0} Properties:", objInfo.Name);
        for (int i = 0; i < propertiesInfo.Length; i++)
        {
            System.Console.WriteLine(propertiesInfo[i].Name);
        }

        // Methods Info
        MethodInfo[] methodInfo = objInfo.GetMethods();
        System.Console.WriteLine("{0} Methods:", objInfo.Name);
        for (int i = 0; i < methodInfo.Length; i++)
        {
            System.Console.WriteLine(methodInfo[i].Name);
        }

    }
}
