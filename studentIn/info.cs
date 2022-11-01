namespace lab43;

public class info
{
    protected string _studentName;
    public string studentName
    {
        get
        {
            return _studentName;
        }
    }

    protected int _age;
    public int Age
    {
        get
        {
            return _age;
        }
    }

    protected int _yearUni;
    public int Year
    {
        get
        {
            return _yearUni;
        }
    }

    public info(string studentName, int age, int yearUni)
    {
        _studentName = studentName;
        _age = age;
        _yearUni = yearUni;
    }
}