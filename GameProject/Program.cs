using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new Member();
            member1.UserName = "yarenkurt078";
            member1.FirstName = "Yaren";
            member1.LastName = "Kurt";
            member1.BirthDay = new DateTime(1998, 4, 11);
            member1.IdentificationNumber = 12345678901;

            Member member2 = new Member();
            member2.UserName = "abdikurt2021";
            member2.FirstName = "Abdi";
            member2.LastName = "Kurt";
            member2.BirthDay = new DateTime(1978, 1, 9);
            member2.IdentificationNumber = 12345432131;

            BaseMemberManager member = new MemberManager(new EDevletServiceAdapter());
            member.Save(member1);
            member.Update(member1, "yarenkurt1998");
            member.Delete(member2);

            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName = "20% Discount",
                Description = "All Games has 20% Discount until end of month",
                StartOfCampaignDate = new DateTime(2022,1,1),
                EndOfCampaignDate = new DateTime(2022,1,31),
                Discount = 0.2

            };

            Game game1 = new Game()
            {
                Id = 1,
                Name = "Sims",
                Price = 399.99,
                Stock = 3
            };

            Game game2 = new Game()
            {
                Id = 2,
                Name = "League of Legends",
                Price = 359.99,
                Stock = 2
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign1);
            campaignManager.AddProduct(campaign1,game2);

           

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(game1);
            saleManager.ClearanceSale(game2,campaign1);


        }
    }
}
