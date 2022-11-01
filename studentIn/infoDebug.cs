namespace lab43;

public abstract class infoDebug : info
{
    public infoDebug(string studentName, int age, int yearUni) : base(studentName, age, yearUni) { }

    virtual public void DebugValue() { }
}