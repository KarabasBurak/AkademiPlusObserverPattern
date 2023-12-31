﻿using AkademiPlusObserverPattern.DAL;
using System;

namespace AkademiPlusObserverPattern.ObservePattern
{
    public class CreateMagazineAnnouncementObserver:IObServer
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();
        public CreateMagazineAnnouncementObserver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim Teknoloji Dergisi",
                Content = "Mayıs sayısı bayimize gelmiştir, kendi lokasyonunuzdaki Avmlerde yer alan şuebelerden ulaşabilirsiniz"
            });
            context.SaveChanges();
        }
    }
}
