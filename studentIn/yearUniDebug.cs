using System.Diagnostics;

namespace lab43;

public class yearUniDebug : infoDebug
{
    public yearUniDebug(string studentName, int age, int yearUni) : base(studentName, age, yearUni) { }

    public override void DebugValue()
    {
        Debug.WriteLine(_yearUni.ToString());
    }
}