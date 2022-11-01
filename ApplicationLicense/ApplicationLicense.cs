namespace lb44;

public class ApplicationLicense
{
    public enum AccessLevels : int
    {
        Free = 1,
        Trial = 2,
        Pro = 3
    }

    private string? _key;
    private Nullable<int> _accessLevel;

    public int accessLevel
    {
        get
        {
            var accessLevel = _accessLevel;

            if (!accessLevel.HasValue)
            {
                accessLevel = _accessLevel = ReadKey();
            }

            return (int)accessLevel;
        }
    }

    public ApplicationLicense(string? key)
    {
        _key = key;
    }

    private int ReadKey()
    {
        switch (_key)
        {
            case "pro":
                return (int)AccessLevels.Pro;
            case "trial":
                return (int)AccessLevels.Trial;
            default:
                return (int)AccessLevels.Free;
        }
    }

    public void printLicense()
    {
        switch (accessLevel)
        {
            case (int)AccessLevels.Free:
                Console.WriteLine("Безкоштовна версія");
                break;
            case (int)AccessLevels.Trial:
                Console.WriteLine("Триальний режим");
                break;
            case (int)AccessLevels.Pro:
                Console.WriteLine("Платна версія");
                break;
        }
    }
}