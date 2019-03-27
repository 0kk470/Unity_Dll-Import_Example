using AOT;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class DllInterface {

    [DllImport("CppInterface")]
    public static extern float GetDistance(float x1, float y1, float x2, float y2);


    //Delegate for C++'s call
    public delegate void LogDelegate(IntPtr message, int iSize);

    [DllImport("CppInterface")]
    public static extern void InitCSharpDelegate(LogDelegate log);

    //C# Function for C++'s call
    [MonoPInvokeCallback(typeof(LogDelegate))]
    public static void LogMessageFromCpp(IntPtr message, int iSize)
    {
        Debug.Log(Marshal.PtrToStringAnsi(message, iSize));
    }
}
