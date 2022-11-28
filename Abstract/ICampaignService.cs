using GameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Abstract
{
    public interface ICampaignService
    {
        void AddGamePriceCampaign(Game game, Campaign campaign);
        void RealUserBasedCampaign(Game game, User user,Campaign campaign);
        Campaign UpdateCampaign(Campaign campaign,DateTime newStartDate,DateTime newEndDate,double newDiscountRate,string campaignName);
        void DeleteCampaign(Campaign campaign);
    }
}
