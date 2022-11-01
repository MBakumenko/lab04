using System.Text;

namespace lab43;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var studentName = "Максим Бакуменко";
        var age = 19;
        var yearUni = 2;

        infoDebug[] debuggers = { new studentNameDebug(studentName, age, yearUni), new ageDebug(studentName, age, yearUni), new yearUniDebug(studentName, age, yearUni) };

        foreach (var debugger in debuggers)
        {
            debugger.DebugValue();
        }

        Console.WriteLine("Виконано!");
    }
}