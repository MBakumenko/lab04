using System.Text;

namespace lb44;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Оберіть ліцензію: ");
        var key = Console.ReadLine();

        var license = new ApplicationLicense(key);

        if (license.accessLevel >= (int)ApplicationLicense.AccessLevels.Pro)
        {
            Console.WriteLine("Функції платної версії доступні");
        }

        if (license.accessLevel >= (int)ApplicationLicense.AccessLevels.Trial)
        {
            Console.WriteLine("Функції триального режиму доступні");
        }

        if (license.accessLevel >= (int)ApplicationLicense.AccessLevels.Free)
        {
            Console.WriteLine("Функції безкоштовної версії доступні");
        }
    }
}