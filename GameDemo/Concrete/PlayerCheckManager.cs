using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace GameDemo.Concrete
{
    public class PlayerCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }

}   
