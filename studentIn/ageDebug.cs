using System.Diagnostics;

namespace lab43;

public class ageDebug : infoDebug
{
    public ageDebug(string studentName, int age, int yearUni) : base(studentName, age, yearUni) { }

    public override void DebugValue()
    {
        Debug.WriteLine(_age.ToString());
    }
}