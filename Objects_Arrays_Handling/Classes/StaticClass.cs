using Objects_Arrays_Handling.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects_Arrays_Handling.Classes;

public static class StaticClass
{
    public static void PrintGenericCollection<T>(this IEnumerable<T> samling)
    {
        Console.WriteLine($"Udskriver samling af type: {typeof(T)}");
        foreach (T element in samling)
        {
            if (element is int intValue)
            {
                Console.Write($"{intValue} ");
            }
            else if (element is IPrintableInteger printable)
            {
                Console.Write($"{printable.IntegerValue} ");
            }
            else
            {
                Console.WriteLine($"Advarsel: Element af type {element?.GetType()} kan ikke udskrives.");
            }
        }
        Console.WriteLine();
    }
}