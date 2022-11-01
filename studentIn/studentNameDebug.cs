using System.Diagnostics;

namespace lab43;

public class studentNameDebug : infoDebug
{
    public studentNameDebug(string studentName, int age, int yearUni) : base(studentName, age, yearUni) { }

    public override void DebugValue()
    {
        Debug.WriteLine(_studentName);
    }
}