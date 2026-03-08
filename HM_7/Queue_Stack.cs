namespace HM_7;

public class Queue_Stack<T>
{
   Queue<T> items = new Queue<T>();

   public void AItem(T item)
   {
      items.Enqueue(item);
   }

   public T ProcessItem()
   {
      return items.Dequeue();
   }

   public void ShowItems()
   {
      Console.WriteLine(string.Join(", ", items));
   }

   public bool HasItems()
   {
      return items.Count > 0;
   }
}
