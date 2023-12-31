﻿using AkademiPlusObserverPattern.DAL;
using System;

namespace AkademiPlusObserverPattern.ObservePattern
{
    public class CreateDiscountCode:IObServer
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();
        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "SALE20",
                DiscountAmount = 20,
                DiscountCodeStatus = true
            });
            context.SaveChanges();
        }


    }
}
