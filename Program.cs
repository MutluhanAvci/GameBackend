using GameBackend.Abstract;
using GameBackend.Concrete;
using GameBackend.Entities;
using GameBackend.Adapters;
using System;

namespace GameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, 
             * kayıtlarını silebileceği bir ortamı simule ediniz. 
             * Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. 
             * (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. 
             * Bunu yapacak servisi simule etmeniz yeterlidir.)

            2.Oyun satışı yapılabilecek satış ortamını simule ediniz.
            ( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. 
            Oyuncunun parametre olarak metotta olmasını kastediyorum.)
            3.Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz
            4.Satışlarda kampanya entegrasyonunu simule ediniz.
            */
            User user = new User
            {
                FirstName = "Mutluhan",
                LastName = "Avcı",
                Id = 1,
                NationalityId = "11122334455"
            };
            Game game = new Game
            {
                Name = "COD MW2",
                Price = 100,
                GameId = 1,

            };
            UserManager userManager = new UserManager();
            userManager.Save(user);
            GameManager gameManager = new GameManager();
            gameManager.Sell(user, game);
            Campaign campaign = new Campaign();
            campaign.CampaignId = 1;
            campaign.CampaignName = "Black Friday";
            campaign.DiscountRate = 25;
            campaign.CampaignStartDate = new System.DateTime(2015, 3, 10, 2, 15, 10);
            campaign.CampaignEndDate = new System.DateTime(2022, 3, 10, 2, 15, 10);
            UserValidationManager userValidationManager = new UserValidationManager();
            CampaignManager campaignManager = new CampaignManager(userValidationManager);
            System.DateTime date1 = new System.DateTime(2016, 3, 10, 2, 15, 10);
            System.DateTime date2 = new System.DateTime(2023, 3, 10, 2, 15, 10);
            campaignManager.UpdateCampaign(campaign, date1, date2, 50, "Kara Cuma");
            Console.WriteLine(campaign.CampaignName);
            UserValidationManager userValidation = new UserValidationManager();
            userValidation.RealPersonValidation(user);
            campaignManager.RealUserBasedCampaign(game, user, campaign);
            MernisManager mernisManager = new MernisManager();
            //CampaignManager campaignManager1 = new CampaignManager(mernisManager);
            //campaignManager1.RealUserBasedCampaign(game, user, campaign);
            IUserService userService = new UserManager();
            
            
            



        }
    }
}
