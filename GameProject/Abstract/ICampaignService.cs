using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        public void AddCampaign(Campaign campaign);
        public void UpdateCampaign(Campaign campaign);
        public void DeleteCampaign(Campaign campaign);
        public void AddProduct(Campaign campaignId, Game gameID);
    }
}
