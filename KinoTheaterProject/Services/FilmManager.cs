using KinoTheaterProject.Models;
using KinoTheaterProject.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KinoTheaterProject.Services
{
    internal class FilmManager : ICrudService, IPrintService
    {

        private Film[] _films = new Film[4];
        private int _currentIndex;
        public void Add(Entity entity)
        {
            if (_currentIndex > 3)
            {
                Console.WriteLine("Maksimum 4 film elave edile biler");
            }
            _films[_currentIndex++] = (Film)entity;
        }

        public void Delete(int id)
        {
            bool check = false;
            for (int i = 0; i < _films.Length; i++)
            {
                if (_films[i] == null)
                    continue;
                if (id == _films[i].Id)
                {
                    check = true;

                    for (int j = 0; j < _films.Length; j++)
                    {
                        _films[j] = _films[ j + 1 ];
                    }
                    _currentIndex++;
                    Console.WriteLine($"{id} ID-li film silindi");
                    return;
                }
            }
        }

        public void DeleteAll(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _films.Length; i++)
            {
                if (_films[i] == null)
                    continue;

                if (id == _films[i].Id)
                {
                    Console.WriteLine(_films[i]);
                    return _films[i];
                }
            }
            Console.WriteLine("Not found");
            return null;
        }

        public void Print()
        {
            foreach (var item in _films)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _films.Length; i++)
            {
                if (_films[i] == null)
                    continue;

                if (_films[i].Id == id)
                {
                    _films[i] = (Film)entity;
                    Console.WriteLine("Ugurla deyisdirildi");
                    return;
                }
            }
            Console.WriteLine("Not found");
        }
    }
}
