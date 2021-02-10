using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IPlayerService
    {
        void Save(Player player);
        void Delete(Player player);
        void Update(Player player);

    }
}
