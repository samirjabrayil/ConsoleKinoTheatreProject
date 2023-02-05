using KinoTheaterProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoTheaterProject.Services.Contracts
{
    internal interface ICrudService
    {
        public void Add(Entity entity);
        public void Delete(int id);
        public void Update(int id, Entity entity);
        public void DeleteAll(int id);
        public Entity Get(int id);
    }
}
