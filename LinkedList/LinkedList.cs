// using Node;
public class LinkedList
{
	Node head;
	Node tail;
	int size;

	public void insertHead(int data)
	{
		Node temp = new Node(data);

		temp.setNext(this.head);
		this.head = temp;
		this.size++;

		if(this.tail == null)
		{
			this.tail = this.head;
		}
	}

	public void printList()
	{
		for(Node temp = this.head; temp.getNext() != null; temp = temp.getNext())
		{
			System.Console.WriteLine(temp.getData());
		}
	}

	public static void Main(string [] args)
	{
		
	}
}