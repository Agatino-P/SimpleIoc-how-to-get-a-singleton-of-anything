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
            Debug.WriteLine($"constructor {DateTime.Now}");
        }
    }
}
