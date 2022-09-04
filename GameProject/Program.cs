using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            GamePlayer player1 = new GamePlayer()
            {
                FirstName = "Fatih Bereket",
                LastName = "İnan",
                DateOfBirth = new DateTime(1995, 8, 13),
                NationaltyId = 18811217616,
                Id = 1
            };

            GamePlayerManager gamePlayerManager = new GamePlayerManager(new MernisCheckManager());
            gamePlayerManager.Save(player1);

            Products product1 = new Products();
            product1.Id = 1;
            product1.Name = "Mario";
            product1.Price = 19.99;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            Campaigns campaign1 = new Campaigns();
            campaign1.Id = 1;
            campaign1.Name = "Summer Sale";
            campaign1.DiscountRate = 20;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.CalculateDiscount(campaign1, product1);

            SalesManager salesManager = new SalesManager();
            salesManager.SellTo(player1, product1);
        }
    }
}
