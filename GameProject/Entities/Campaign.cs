using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string Description { get; set; }
        public double Discount { get; set; }
        public DateTime StartOfCampaignDate { get; set; }
        public DateTime EndOfCampaignDate { get; set; }
    }
}
