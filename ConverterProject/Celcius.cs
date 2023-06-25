using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterProject
{
    public class Celcius : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 0, -17.8};
            yield return new object[] { -10, -23.3};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
