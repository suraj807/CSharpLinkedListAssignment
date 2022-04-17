using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructureAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<int> list = new CustomLinkedList<int>(); // creating a object of in built LinkedList generic class 
            list.AddFirst(70); // Calling method of CustomLinkedList generic class to add 56 at first
            list.AddFirst(30); // Calling method of CustomLinkedList generic class to add 30 at last
            list.AddFirst(56); // Calling method of CustomLinkedList generic class to add 70 at last
            list.DisplayElement(); // Calling method of CustomLinkedList generic class to display linkedlist element
            Console.ReadLine();
        }
    }
}