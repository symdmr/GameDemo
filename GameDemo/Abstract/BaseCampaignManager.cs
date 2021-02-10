using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " campaign deleted!" + " Ayrıca detayı şu şekilde: " + campaign.CampaignDetails);
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " campaign saved!" + " Ayrıca detayı şu şekilde: " + campaign.CampaignDetails);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " campaign updated!" + " Ayrıca detayı şu şekilde: " + campaign.CampaignDetails);
        }
    }
}
