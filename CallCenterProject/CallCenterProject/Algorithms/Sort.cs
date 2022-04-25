using CallCenterProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProject.Algorithms
{
    public  class Sort
    {
        // Siralamak icin kullanilir, Func<> yapisi fonksiyona parametre olarak kontrol kosulunu vermek icin kullanilir
        public List<TarihRapor> Insertionsort(List<TarihRapor> list, Func<TarihRapor, TarihRapor, bool> comparer)
        {
            for (int i = 1; i < list.Count; i++)
            {
                TarihRapor current = list[i];

                int j = i - 1;
                for (; j >= 0 && comparer(current, list[j]); j--)
                {
                    list[j + 1] = list[j];
                }
                list[j + 1] = current;
            }

            return list;
        }


        










    }
}
