using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corruption_Checksum
{
    class Row
    {
        public int[] Data { get; set; }
        public int Checksum { get; set; }

        public Row(params int[] _data)
        {
            Data = _data;
            Checksum = CalculateChecksum(_data);
        }

        private int CalculateChecksum(int[] row)
        {
            int smallest = Int32.MaxValue;
            int largest = 0;

            foreach (int number in row)
            {
                if (number < smallest)
                    smallest = number;
                if (number > largest)
                    largest = number;
            }

            return largest - smallest;
        }
    }
}
