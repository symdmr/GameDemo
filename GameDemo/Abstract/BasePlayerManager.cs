using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Entities;



namespace GameDemo.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Save(Player player)
        {
            Console.WriteLine("saved to db: " + player.FirstName + " " + player.LastName);
        }

        public virtual void Delete(Player player)
        {
            Console.WriteLine("deleted from db: " + player.FirstName + " " + player.LastName);
        }

        public virtual void Update(Player player)
        {
            Console.WriteLine("player updated: " + player.FirstName + " " + player.LastName);
        }
    }
}
