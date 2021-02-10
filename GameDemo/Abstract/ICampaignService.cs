using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface ICampaignService
    {
        void Save(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);

    }
}
