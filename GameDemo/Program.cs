using GameDemo.Abstract;
using GameDemo.Adapter;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;
using System.Threading.Tasks;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //kimlik doğrulama

            Player player = new Player
            {
                DateOfBirth = new DateTime(1994, 11, 23),
                FirstName = "Şeyma",
                LastName = "Demir",
                NationalityId = 123456789

            };
            BasePlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            playerManager.Save((Player)player);


            //oyuncu silme-güncelleme
            BasePlayerManager playerManager1 = new PlayerManager();
            playerManager1.Delete((Player)player);
            playerManager1.Update((Player)player);


            //kampanya ekle-sil-güncelle
            Campaign campaign = new Campaign
            {
                CampaignId = 1,
                CampaignName = "Patron Çıldırdı",
                CampaignDetails = "2021 yılı sonuna kadar sürecek!"

            };

            Campaign campaign1 = new Campaign
            {
                CampaignId = 2,
                CampaignName = "Kapatıyoruz",
                CampaignDetails = "2021 Ocak'ta sona erdi..."
            };

            BaseCampaignManager campaignManager = new CampaignManager();
            campaignManager.Save((Campaign)campaign);
            campaignManager.Update((Campaign)campaign);
            campaignManager.Delete((Campaign)campaign1);


            //oyuncu ve satış

            IGameSalesService gameSales = new SalesManager();
            gameSales.Save((Player)player,(Campaign)campaign);
            gameSales.Update((Player)player, (Campaign)campaign);
            gameSales.Delete((Player)player, (Campaign)campaign1);


        }
    }
}
