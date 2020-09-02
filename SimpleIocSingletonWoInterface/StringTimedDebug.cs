using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public static class StringTimedDebug
    {
        public static void DP (this string text)
        {
            Debug.WriteLine($"{DateTime.Now}: {text} ");
        }
    }
}
