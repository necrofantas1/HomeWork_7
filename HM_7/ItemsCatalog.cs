namespace HM_7;

public class ItemsCatalog
{
    Dictionary<int, string> itemsCatalog = new Dictionary<int, string>();

    public void AddItem(int barcode, string name)
    {
        if (!itemsCatalog.ContainsKey(barcode))
        {
            itemsCatalog.Add(barcode, name);
        }

        else
        {
            Console.WriteLine("Item already exists");
        }

    }

    public string? GetItem(int barcode)
    {
        itemsCatalog.TryGetValue(barcode, out string? name);
        return name;
    }
}


    