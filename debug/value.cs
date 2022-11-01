using System.Diagnostics;

namespace lab41;

public class value
{
    virtual internal void WriteInDebug(string stringParam, int intParam)
    {
        Debug.WriteLine("String Parameter: " + stringParam);
        Debug.Write("Integer Parameter: " + intParam);
    }
}