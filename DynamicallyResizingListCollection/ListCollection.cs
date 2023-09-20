using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicallyResizingListCollection
{
    class ListCollection
    {
        static void Main()
        {
            var items = new List<string>();

            Console.WriteLine("Before adding to items: " +
                $"Count = {items.Count}; Capacity = {items.Capacity}");

            items.Add( "red" );
            items.Insert(0, "yellow");

            Console.WriteLine("after adding two elements to items: " +
                $"Count = {items.Count}; Capacity = {items.Capacity}");

            Console.WriteLine("\nDisplay list contents with counter-controlled" +
                " loop:");

            for (var i = 0; i < items.Count; i++)
            {
                Console.WriteLine($" {items[i]}");
            }

            Console.WriteLine("\nDisplay list contents with foreach statement:");
            foreach(var item in items)
            {
                Console.Write($" {item}");
            }

            items.Add("green");
            items.Add("yellow");

            Console.WriteLine("\n\nAfter adding two more elements to items: " + 
                $"Count = {items.Count}; Capacity = {items.Capacity}");

            Console.WriteLine("\nList with two new elements:");
            foreach(var item in items)
            {
                Console.Write($" {item}");
            }

            items.Remove("yellow");

            Console.Write("\n\nRemove first instance of yellow:");

            foreach(var item in items)
            {
                Console.Write($" {item}");
            }

            items.RemoveAt(1);

            Console.Write("\nRemove second list element (green):");
            foreach(var item in items)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine("\nAfter removing two elements from items: " +
                $"Count = {items.Count}; Capacity = {items.Capacity}");

            Console.WriteLine("\n\"red\" is " +
                $"{(items.Contains("red") ? string.Empty : "not ")}int the list");

            items.Add("orange");
            items.Add("violet");
            items.Add("blue");

            Console.WriteLine("\nAfter adding three more elements to items: " +
                $"Count = {items.Count}; Capacity = {items.Capacity}");

            Console.Write("List with three new elements: ");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
        }
    }
}
