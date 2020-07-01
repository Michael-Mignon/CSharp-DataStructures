// using System;

class Node
{
	int data;
	Node next;

	public Node(int data)
	{
		this.data = data;
	}
}

public class LinkedList
{
	Node head;
	Node tail;
	int size;

	public void insertHead(int data)
	{
		Node temp = new Node(data);
		temp.next = this.head;
		this.head = temp;
		this.size++;
		if(this.tail == null)
		{
			this.tail = this.head;
		}
	}

	public void printList()
	{
		for(Node temp = this.head; temp.next != null; temp = temp.next)
		{
			System.Console.WriteLine(temp.data);
		}
	}

	public static void Main(string [] args)
	{
		
	}
}