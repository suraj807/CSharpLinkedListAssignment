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
            list.Append(56); // Calling method of CustomLinkedList generic class to append 56
            list.Append(30); // Calling method of CustomLinkedList generic class to append 70
            list.Append(70); // Calling method of CustomLinkedList generic class to append 30 
            list.DisplayElement(); // Calling method of CustomLinkedList generic class to display linkedlist element
            list.Search(30); // Calling method of CustomLinkedList generic class to search element in linkedlist
            list.InsertElement(30, 40);
            list.DisplayElement();
            list.DeleteElement(40);
            list.DisplayElement();
            Console.ReadLine();
        }
    }
}