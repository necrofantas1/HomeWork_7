namespace HM_7;

public class VipClients
{
        SortedList<int, string> vipClients = new SortedList<int, string>();
        
        public void AddVIPClient(int clientID, string name)
        {
            vipClients.Add(clientID, name);
        }
        
        public void ShowAllClients()
        {
            foreach (var client in vipClients)
                Console.WriteLine($"ID: {client.Key} — {client.Value}");
        }

        public void ShowReverseClients()
        {
            for ( int i = vipClients.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"ID: {vipClients.Keys[i]} — {vipClients.Values[i]}");
            }
    }
}