using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public interface IRepository<T,I> where T:I
    {
    }
}
