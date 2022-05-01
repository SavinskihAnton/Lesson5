using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] ukvalue = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book"; ukvalue[0] = "кнг";
            key[1] = "ручка"; value[1] = "pen"; ukvalue[1] = "рчк";
            key[2] = "солнце"; value[2] = "sun"; ukvalue[2] = "слнц";
            key[3] = "яблоко"; value[3] = "apple"; ukvalue[3] = "блк";
            key[4] = "стол"; value[4] = "table"; ukvalue[4] = "стл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index)
                        return key[i] + " - " + value[i] + " - " + ukvalue[i];
                for (int i = 0; i < value.Length; i++)
                    if (value[i] == index)
                        return value[i] + " - " + key[i] + " - " + ukvalue[i];
                for (int i = 0; i < ukvalue.Length; i++)
                    if (ukvalue[i] == index)
                        return ukvalue[i] + " - " + value[i] + " - " + key[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index] + " - " + ukvalue[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
