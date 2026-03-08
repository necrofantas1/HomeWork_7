namespace HM_7;
using HM_7.Exeptions;


public class LinkedList
{
    LinkedList<string> _head = new LinkedList<string>();

    public void AddFirst(string item)
    {
        _head.AddFirst(item);
    }
    
    public void AddLast(string item)
    {
        _head.AddLast(item);
    }
    
    public void AddAfter(string exist, string after)
    {
        LinkedListNode<string>? node = _head.Find(exist);
        
        if (node != null)
        {
            _head.AddAfter(node, after);
        }

        if (node == null)
        {
            throw new NodeNotFoundExсeption();
        }
    }
    
    public void ShowAll()
    {
        foreach (var item in _head)
        {
            Console.WriteLine(item);
        }
    }
}





