using GameBackend.Abstract;
using GameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace GameBackend.Concrete
{
    class CampaignManager : ICampaignService
    {
        private IUserValidationService userValidationService;

        public CampaignManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void AddGamePriceCampaign(Game game, Campaign campaign)
        {
            game.Price *= campaign.DiscountRate/100;
            Console.WriteLine($"Discounted price for {game.Name} is {game.Price}");         
        }

        public void DeleteCampaign(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void RealUserBasedCampaign(Game game, User user,Campaign campaign)
        {
            if (userValidationService.RealPersonValidation(user))
            {
                game.Price = game.Price - ((game.Price * campaign.DiscountRate) / 100);
            }
            else
            {
                throw new Exception("Not a valid user yet");
            }                                
        }

        public Campaign UpdateCampaign(Campaign campaign, DateTime newStartDate, DateTime newEndDate, double newDiscountRate, string campaignName)
        {
            campaign.CampaignStartDate = newStartDate;
            campaign.CampaignEndDate = newEndDate;
            campaign.DiscountRate = newDiscountRate;
            campaign.CampaignName = campaignName;
            return campaign;
        }
    }
}
