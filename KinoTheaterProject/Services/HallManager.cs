using KinoTheaterProject.Models;
using KinoTheaterProject.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace KinoTheaterProject.Services
{
    internal class HallManager : IPrintService
    {
        private Hall[] _halls = new Hall[4];
        private int _currentIndex;
        public void Add(Entity entity)
        {
            if (_currentIndex > 3)
            {
                Console.WriteLine("Elave etmek olmaz! 4 zal var!");
            }
            _halls[_currentIndex++] = (Hall)entity;
        }

        public Entity Get(int id)
        {

            for (int i = 0; i < _halls.Length; i++)
            {
                if (_halls[i] == null)
                    continue;

                if (id == _halls[i].Id)
                {
                    Console.WriteLine(_halls[i]);
                    return _halls[i];
                }
            }
            Console.WriteLine("Not Found!!");
            return null;
        }

        public void Print()
        {
            foreach (var item in _halls)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item.ToString());
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _halls.Length; i++)
            {
                if (_halls[i] == null)
                {
                    continue;
                }

                if (_halls[i].Id == id)
                {
                    _halls[i] = (Hall)entity;
                    Console.WriteLine("Ugurla deyisdirildi!");
                    return;
                }
            }
            Console.WriteLine("Not Found!!");
        }
    }
}
