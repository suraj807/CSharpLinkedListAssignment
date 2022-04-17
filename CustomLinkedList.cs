using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructureAssignments
{
    internal class CustomLinkedList<T>
    {
        public Node<T> head; // Creatind head if linked list
        public void AddFirst(T data) // creating generic method to Add element at first of linked list
        {
            Node<T> newNode = new Node<T>(data); // Creating a new node 
            if (head == null)
            {
                head = newNode; // If head pointing to null then hode is directly pointing to new node
                Console.WriteLine($"{newNode.data} is inserted at first of linked list");
                return;
            }
            newNode.next = this.head; // newnode pointing to where head is currently pointing
            head = newNode; // head is pointing to new node
            Console.WriteLine($"{newNode.data} is inserted at first of linked list");
        }
        public void DisplayElement() // creating generic method to display element at first of linked list
        {
            {
                Node<T> temp = this.head; // taking head as temp node
                if (temp == null) // If head is null that means linked list is empty
                {
                    Console.WriteLine("\nThe LinledList is Empty");
                    return;
                }
                Console.WriteLine("\nElements of linked list in sequence are : ");
                while (temp != null) // If head is not null then print one by one element of linked list
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next; // Go to next node
                }
            }
        }
    }
}