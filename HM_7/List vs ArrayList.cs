using System.Collections;
using System.Diagnostics;

namespace HM_7;

public class List_vs_ArrayList
{
     int COUNT = 1_000_000;

    public void RunTest()
    {
        TestArrayList();
        TestList();
        Console.ReadKey();
    }
    
    

    private void TestArrayList()
    {
        var array = new ArrayList();
        
        var sw = new Stopwatch();
        var memory = GC.GetTotalMemory(true);

        sw.Start();
        
        for (int i = 0; i < COUNT; i++)
        {
            array.Add(i);
        }
            
        sw.Stop();
        
        long memAfter = GC.GetTotalMemory(false);
        
        Console.WriteLine("ArrayList");
        Console.WriteLine($"{sw.ElapsedMilliseconds}");
        Console.WriteLine($"{memAfter - memory}");

    }

    private void TestList()
    {
        var list = new List<int>();

        var sw = new Stopwatch();
        var memory = GC.GetTotalMemory(true);
        
        sw.Start();

        for (int i = 0; i < COUNT; i++)
        {
            list.Add(i);
        }
        
        sw.Stop();
        long memAfter = GC.GetTotalMemory(false);
        
        Console.WriteLine("List");
        Console.WriteLine($"{sw.ElapsedMilliseconds}");
        Console.WriteLine($"{memAfter - memory}");
    }
}