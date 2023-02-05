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
    internal class SeansManager : IPrintService
    {

        private Seans[] _sessions = new Seans[4];
        private int _sessionCount;
        public void Add(Entity entity)
        {
            if (_sessionCount > 3)
            {
                Console.WriteLine("4 seans movcuddur, basqa elave etmek olmaz");
            }
            _sessions[_sessionCount++] = (Seans)entity;
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _sessions.Length; i++)
            {
                if (_sessions[i] == null)
                    continue;

                if (id == _sessions[i].Id)
                {
                    Console.WriteLine(_sessions[i]);
                    return _sessions[i];
                }
            }
            Console.WriteLine("Not Found!!");
            return null;
        }

        public void Print()
        {
            foreach (var item in _sessions)
            {
                if (item == null)
                    continue;
                Console.WriteLine(item);
            }
        }


    }
}
