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

		if (this.tail == null)
		{
			this.tail = this.head;
		}
	}

	public void insertTail(int data)
	{
		Node temp = new Node(data);
		
		if (this.tail == null)
		{
			this.head = this.tail = temp;
			return;
		}

		this.tail.setNext(temp);
		this.tail = temp;
		this.size++;

		if (this.head == null)
		{
			this.head = this.tail;
		}
	}

	public int deleteTail()
	{
		int retVal;
		Node runner;

		if (this.head == null || this.tail == null)
		{
			return System.Int32.MinValue;
		}

		if (this.head == this.tail)
		{
			retVal = this.tail.getData(); 
			this.head = this.tail = null;
			return retVal;
		}

		for (runner = this.head; runner.getNext() != this.tail; runner = runner.getNext())
			;

		retVal = this.tail.getData();
		this.tail = runner;
		this.size--;

		return retVal;
	}

	public int deleteHead()
	{
		int retVal;
		
		if (this.head == null)
		{
			return System.Int32.MinValue;
		}

		retVal = this.head.getData();
		this.head = this.head.getNext();
		this.size--;

		return retVal;
	}

	public int delete(int position)
	{
		Node runner = this.head;
		int retVal;

		if (this.head == null || this.size < position || position < 0)
		{
			return System.Int32.MinValue;
		}

		if (position == 0)
		{
			return this.deleteHead();
		}

		if (position == this.size - 1)
		{
			return this.deleteTail();
		}

		for (int i = 0; i < position - 1; i++)
		{
			runner = runner.getNext();
		}

		retVal = runner.getNext().getData();
		runner.setNext(runner.getNext().getNext());
		this.size--;

		return retVal;
	}

	public void printList()
	{
		for (Node temp = this.head; temp != null; temp = temp.getNext())
		{
			System.Console.WriteLine(temp.getData());
		}
	}

	public static void Main(string [] args)
	{
		// Demo Here
		// All methods testing working
	}
}