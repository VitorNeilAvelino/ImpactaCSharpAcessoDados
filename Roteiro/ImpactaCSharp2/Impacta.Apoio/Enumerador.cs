using System;
using System.Collections.Generic;
using System.Linq;

namespace Impacta.Apoio
{
    public static class Enumerador
    {
        public static List<T> ParaLista<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>().OrderBy(x => x.ToString()).ToList();
        }
    }
}