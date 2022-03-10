using System;
using System.Collections.Generic;
using System.Text;

namespace P129Event.Models
{
    class Product
    {
        public string Name { get; set; }
        private int _count;
        public int Count 
        {
            get => _count;
            set
            {
                if (value <= 10)
                {
                    Notify += () => Console.WriteLine($"Mehsulun Sayi {value} Qeder");
                    
                }

                if (value <= 40)
                {
                    Notify += () => Console.WriteLine($"Mehsulun 10-dan Cox Salib");
                    
                }
                _count = value;
            }
        }
        public event Action Notify 
        {
            add
            {
                Console.WriteLine($"Add {value.Method.Name}");
                value.Invoke();
            }
            remove
            {
                Console.WriteLine($"Remove {value.Method.Name}");
                value.Invoke();

            }
        }

        public void Sell(int count)
        {
            Count -= count;
        }
    }
}
