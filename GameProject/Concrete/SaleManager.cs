using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Game game)
        {
            Console.WriteLine(game.Name+" has been sold for "+game.Price);
        }

        public void ClearanceSale(Game game, Campaign campaign)
        {
            double newPrice = game.Price * campaign.Discount;
            Console.WriteLine(game.Name + " has been sold for " + newPrice+" with 20% Discount. This Discount is available until"+campaign.EndOfCampaignDate);
        }
    }
}
