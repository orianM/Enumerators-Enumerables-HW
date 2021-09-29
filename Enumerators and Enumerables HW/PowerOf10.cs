using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators_and_Enumerables_HW
{
    class PowerOf10 : IEnumerable<double>
    {
        public int Number { get; set; }

        public PowerOf10(int number)
        {
            this.Number = number;
        }

        public IEnumerator<double> GetEnumerator()
        {
            for (int i = 1; i <= 1; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    yield return Math.Pow(Number, j);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
