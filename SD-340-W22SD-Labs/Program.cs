LinkedList<int> list1 = new LinkedList<int>();
list1.Add(1);
list1.Add(2);
list1.Add(3);
list1.Print();

LinkedList<string> list2 = new LinkedList<string>();
list2.Add("a");
list2.Add("b");
list2.Add("c");
list2.Print();

class LinkedList<T>
{
    private List<Node<T>> Nodes { get; set; }

    public LinkedList()
    {
        Nodes = new List<Node<T>>();
    }

    public void Add(T data)
    {
        Node<T> node = new Node<T>(data, Nodes.Count > 0 ? Nodes.Last() : null);
        Nodes.Add(node);
    }

    public void Print()
    {
        foreach(Node<T> node in Nodes)
        {
            node.Print();
        }
    }
}

class Node<T>
{
    public T Data { get; set; }
    public Node<T>? Next { get; set; }

    public Node(T data, Node<T>? next)
    {
        Data = data;
        Next = next;
    }

    public void Print()
    {
        Console.WriteLine(Data?.ToString());
    }
}