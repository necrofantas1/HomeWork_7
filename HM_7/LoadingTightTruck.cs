namespace HM_7;

public class LoadingTightTruck <T> where T : class
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


