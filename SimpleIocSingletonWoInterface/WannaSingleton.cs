using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public class WannaSingleton : IWannaSingleton
    {
        public WannaSingleton()
        {
           "Within WannaSingleton Constructor".DP();
        }

            public void PrintToDebug(string text)
        {
            $"Inside WannaSingleton Method - {text}".DP();
        }

    }
}
