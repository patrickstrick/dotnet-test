using System;                                                                                                                    │
using System.Diagnostics;                                                                                                        │
                                                                                                                                 │
class Program                                                                                                                    │
{                                                                                                                                │
    static void Main()                                                                                                           │
    {                                                                                                                            │
        while (true)                                                                                                             │
        {                                                                                                                        │
            Console.WriteLine("this is a log");                                                                                  │
            Debug.WriteLine("this is a debug message");                                                                          │
            Trace.WriteLine("this is a trace message");                                                                          │
        }                                                                                                                        │
    }                                                                                                                            │
} 