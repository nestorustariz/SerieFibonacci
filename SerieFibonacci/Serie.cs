using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;

namespace SerieFibonacci
{
    public class Serie : IEnumerable<int>
    {

        public IEnumerator<int> GetEnumerator()
        {
            yield return 1;

            for (int i = 1; true ; i++)
            {
                yield return i;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
