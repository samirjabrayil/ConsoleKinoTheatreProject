﻿using KinoTheaterProject.Models;
using KinoTheaterProject.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoTheaterProject.Services
{
    internal class TIcketManager : IPrintService
    {

        private Tickets[] _tickets = new Tickets[100];
        private int _ticketCount;

        public void Add(Entity entity)
        {
            if (_ticketCount > 99)
            {
                Console.WriteLine("Bilet bitti! Basqa elave etmek olmaz");
            }
            _tickets[_ticketCount++] = (Tickets)entity;
        }

        public void Print()
        {
            foreach (var item in _tickets)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item.ToString());
            }
        }

        public Entity Get(int id)
        {

            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                    continue;

                if (id == _tickets[i].Id)
                {
                    Console.WriteLine(_tickets[i]);
                    return _tickets[i];
                }
            }
            Console.WriteLine("Not Found!!");
            return null;
        }

    }
}
