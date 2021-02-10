using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IGameSalesService
    {
        void Save(Player player, Campaign campaign);
        void Update(Player player, Campaign campaign);
        void Delete(Player player, Campaign campaign);

    }
}
