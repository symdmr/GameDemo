using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class SalesManager : IGameSalesService
    {
        public void Delete(Player player, Campaign campaign)
        {
            Console.WriteLine(player.FirstName + " isimli oyuncu " + campaign.CampaignName + " isimli kampanyadan yararlanmayı sona erdirdi.");
        }

        public void Save(Player player, Campaign campaign)
        {
            Console.WriteLine(player.FirstName + " isimli oyuncu " + campaign.CampaignName + " isimli kampanyadan yararalanmak için kayıt oldu!");
        }

        public void Update(Player player, Campaign campaign)
        {
            Console.WriteLine(player.FirstName + " isimli oyuncu " + campaign.CampaignName + " isimli kampanyasını güncelledi!");
        }
    }
}
