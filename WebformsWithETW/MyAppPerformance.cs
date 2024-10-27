using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebformsWithETW
{
    public sealed class MyAppPerformance : System.Diagnostics.Tracing.EventSource
    {
        private MyAppPerformance()
        {
        }

        public static MyAppPerformance Log { get; } = new MyAppPerformance();

        [System.Diagnostics.Tracing.Event(1)]
        public void Perf(string classname, string methodname, string message, int objectid)
        {
            base.WriteEvent(1, classname, methodname, message, objectid);
        }
    }
}