using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Entities
{
    public class Campaign:IEntities
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public double DiscountRate { get; set; }
        public DateTime CampaignStartDate { get; set; }
        public DateTime CampaignEndDate { get; set; }
    }
}
