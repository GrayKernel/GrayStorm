using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrayStorm
{
    #region dataBox
    public class dataBox
    {
        public string name;
        public byte[] data;
        public int indexToStartCleaning;

        public dataBox(string nameIN, byte[] dataIN, int indexToStartCleaningIN)
        {
            name = nameIN;
            data = dataIN;
            indexToStartCleaning = indexToStartCleaningIN;
        }

        public override string ToString()
        {
            return name;
        }
    }
    #endregion dataBox
}
