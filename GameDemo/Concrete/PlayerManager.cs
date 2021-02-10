using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class PlayerManager : BasePlayerManager
    {
        IPersonCheckService personCheckService;

        public PlayerManager()
        {
        }

        public PlayerManager(IPersonCheckService personCheckService)
        {
            this.personCheckService = personCheckService;
        }

        public override void Save(Player player)
        {
            if (this.personCheckService.CheckIfRealPerson(player))
            {
                base.Save(player);
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }
            
        }

       



    }

  
}
