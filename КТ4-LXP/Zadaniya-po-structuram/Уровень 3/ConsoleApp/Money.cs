using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public struct Money
    {
        public int Rubles;
        public int Kopecks;
        
        private int allInKopecks()
        {
            return Rubles * 100 + Kopecks;
        }
        
        public Money(int rubles, int kopecks)
        {
            int allInKopecks = rubles * 100 + kopecks;
            Rubles = allInKopecks / 100;
            Kopecks = allInKopecks % 100;
        }

        public Money Add(Money second)
        {
            return new Money(0, allInKopecks() + second.allInKopecks());
        }
        public Money Subtract(Money second)
        {
            return new Money(0, allInKopecks() - second.allInKopecks());
        }

        public bool IsGreaterThan(Money second)
        {
            return allInKopecks() > second.allInKopecks();
        }

        public bool IsLessThan(Money second)
        {
            return allInKopecks() < second.allInKopecks();
        }
    }
}
