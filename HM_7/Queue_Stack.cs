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

class LoadingTightTruck<T> where T : class
{
   Stack<T> items = new Stack<T>();
   private const int TRUCKCAPACITY = 10;

   public void Load(T item)
   {
      if (items.Count == TRUCKCAPACITY)
      {
         Console.WriteLine("Truck is full");
         return;
      }

      items.Push(item);
   }

   public T? Unload()
   {
      if (items.Count == 0) return null;

      return items.Pop();
   }

   public bool IsFull()
   {
      return items.Count == TRUCKCAPACITY;
   }
}