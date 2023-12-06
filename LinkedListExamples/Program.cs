using System.Collections.Generic;
//Insertion at the beginning of LIST
//Creation of class Node having value and refrence with the constructor to initialize value
public class Node
{
    public string Data;
    public Node? Next;

    public Node(string data)
    {
        Data = data;
        Next = null;
    }
}
class LinkedList
{
    private Node? head;

    public void InsertAtStart(string data)
    {
        //creating a new node
        Node newNode = new Node(data);
        //setting the new node pointer to next node i.e head as it is pointing towards it
        newNode.Next = head; 
        // refactor head to newNode
        head = newNode; 
    }
    public void InsertAfterNode(Node previousNode, string data)
    {
        if(previousNode == null)
        {
            Console.WriteLine("Node cannot be NUll");
        }
        Node newNode = new Node(data);
        newNode.Next = previousNode.Next;
        previousNode.Next = newNode;

    }
    public Node findNode(string data)
    {
        Node temp = head;
        while(temp != null)
        {
            if (temp.Data == data)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }
    public void Display()
    {
        // Using a temp variable to traverse
        Node ?temp = head;
        while(temp != null)
        {
            Console.WriteLine(temp.Data);
            temp = temp.Next;
        }
    }
}

class driverProgram
{
    public static void Main()
    {
        LinkedList myList = new LinkedList();
        myList.InsertAtStart("List!");
        myList.InsertAtStart("Ban Gyi");
        myList.InsertAtStart("To");
        myList.InsertAtStart("Ab");
        myList.Display();

        //Providing previous node by finding it using data and then inserting it.
        Node givenNode = myList.findNode("Ban Gyi");
        if(givenNode != null )
        myList.InsertAfterNode(givenNode, "NewNode");
        myList.Display();
    }
}


