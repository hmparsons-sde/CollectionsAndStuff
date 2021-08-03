using System;
using System.Collections.Generic;

namespace CollectionsAndStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // all of these methods mutate the original collection.

            // List<T> is a generic type, a type that requires us to tell it what type of stuff it does/uses
            // in this case, 'string' is a type parameter used to tell the List<T> how to work.
            var e14Names = new List<string>();
            // add a single item
            e14Names.Add("Holly");

            //put the item in a certain spot
            e14Names.Insert(1, "Sare");

            // collection initializers - curly braces
            var teacherNames = new List<string> { "nathan", "jameka", "dylan", "tom" };

            // An interface contains definitions for a group of related functionalities that a non-abstract class or a struct must implement. 
            // Interfaces have no access modifiers.
            // can only inherit from a class onnce; can implement as many interfaces as I want
            // add one collection to the other
            e14Names.AddRange(teacherNames);
            //remove from collection
            e14Names.Remove("tom");
            // remove by index
            e14Names.RemoveAt(0);
            // remove by expression
            // lambda expression
            // Removes all the elements that match the conditions defined by the specified predicate.
            // Predicate = epresents the method that defines a set of criteria and determines whether the specified object meets those criteria.
            e14Names.RemoveAll(name => name.StartsWith("n"));
            //  Find by index
            var firstStudent = e14Names[0];
            // normal c# foreach loop
            foreach (var name in e14Names)
            {
                Console.WriteLine($"{name} is in e14!");
            }

            // list specific loop, takes in an Action<T>
            e14Names.ForEach(name => Console.WriteLine($"{name} is in e14!"));

            // DICTIONARY<TKey, TValue> (t = type)
            // Open Generic - no one has specified what type of thing it is yet. 
            // like a physical dictionary, kinda
            // keys have to be unique
            // our dictionary is keyed by strings and has strings
            // much more specific, optimized; find one thing really quickly
            // think of it like retrieving objects by id or by firebase key (in frontend)
            var dictionary = new Dictionary<string, string>();

            // adding things requires key + value
            dictionary.Add("penultimate", "second to last");
            dictionary.Add("Jib", "The things that sticks out of rollercoasters.");
            dictionary.Add("Arbitrary", "Someone who doesn't like Arby's.");

            // get one thing based on its key
            // dictionaries require each key to be unique
            var definition = dictionary["Arbitrary"];

            // try methods return a boolean indicating success or failure
            // ! indicates that the starting boolean is "false", rather than "true"
            if (!dictionary.TryAdd("penultimate", "second to last"))
            {
                Console.WriteLine("already here");
            }

            // much less expensive way to test
            if (dictionary.ContainsKey("penultimate"))
            {
                dictionary["penultimate"] = "already here, bro";
            }

            // give me all the keys in a collection
            var allTheWords = dictionary.Keys;

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine($"{item.Key}'s definition is {item.Value}");
            //}

            // I can destructure stuff
            foreach (var (word, def) in dictionary)
            {
                Console.WriteLine($"{word}'s definition is {def}");
            }


            var complicatedDictionary = new Dictionary<string, List<string>>();

            complicatedDictionary.Add("Soup", new List<string> { "Hot or cold liquid you eat." });
            var soupDefinitions = complicatedDictionary["Soup"];
            soupDefinitions.Add("This is a definition of soup");

            complicatedDictionary.Add("Arity", new List<string> { "A definition of arity" });

            foreach (var (word, definitions) in complicatedDictionary)
            {
                Console.WriteLine(word);
                foreach (var def in definitions)
                {
                    Console.WriteLine($"\t{def}");
                }
            }

            // HASHSETS
            // Like a list - store a value at an index
            // like a dictionary - each value has to be unique
            // different - eliminates non-unique stuff without errors
            // The HashSet<T> class provides high-performance set operations. A set is a collection that contains no duplicate elements, and whose elements are in no particular order.
            var uniqueNames = new HashSet<string>();
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Jameka");
            uniqueNames.Add("Dylan");
            uniqueNames.Add("Dylan");
            uniqueNames.Add("Dylan");

            uniqueNames.Remove("Dylan");

            foreach(var name in uniqueNames)
            {
                Console.WriteLine($"{name} is unique");
            }

            // QUEUES
            // Objects stored in a Queue<T> are inserted at one end and removed from the other. 
            // FIFO (first in, first out)
            // Queues and stacks are useful when you need temporary storage for information; that is, when you might want to discard an element after retrieving its value.
            // Use Queue<T> if you need to access the information in the same order that it is stored in the collection. 
            // Three main operations can be performed on a Queue<T> and its elements:
            // Enqueue adds an element to the end of the Queue<T>.
            // Dequeue removes the oldest element from the start of the Queue<T>.
            // Peek peek returns the oldest element that is at the start of the Queue<T> but does not remove it from the Queue< T >.
            var queue = new Queue<int>();
            queue.Enqueue(3);
            queue.Enqueue(1);
            queue.Enqueue(5);
            queue.Enqueue(7);
            queue.Enqueue(2);
            queue.Enqueue(100);
            queue.Enqueue(6);

            while(queue.Count > 0)
            {
                Console.WriteLine($"dequeuing {queue.Dequeue()}");
            }
            
            // STACKS
            // LIFO - last in, first out
            // Stacks and queues are useful when you need temporary storage for information; that is, when you might want to discard an element after retrieving its value
            // Use System.Collections.Generic.Stack<T> if you need to access the information in reverse order.
            // Three main operations can be performed on a System.Collections.Generic.Stack<T> and its elements:
            //  Push inserts an element at the top of the Stack.
            //  Pop removes an element from the top of the Stack<T>.
            //  Peek returns an element that is at the top of the Stack<T> but does not remove it from the Stack< T >.
            //  things done in order, but with a bias towards recency
            var stack = new Stack<int>();

            stack.Push(2);
            stack.Push(5);
            stack.Push(12);
            stack.Push(24);
            stack.Push(23);
            stack.Push(200);
            stack.Push(2231);

            while(stack.Count > 0)
            {
                Console.WriteLine($"popping {stack.Pop()}");
            }
            
            // TUPLES
            // A tuple is a data structure that has a specific number and sequence of values.
            // The Tuple<T1,T2> class represents a 2-tuple, or pair, which is a tuple that has two components.
        }
    }
}
