using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : Icampaign
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign is add" + campaign.CampaignName + "DiscountRate is " + campaign.Discount);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign is delete" + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign is update" + campaign.CampaignName + "DiscountRate is " + campaign.Discount);
        }
    }
}
