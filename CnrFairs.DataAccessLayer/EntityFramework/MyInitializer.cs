using CnrFairs.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.DataAccessLayer.EntityFramework
{
    public class MyInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            Language trLanguage = new Language
            {
                Name = "Türkçe",
                LanguageCulture = "tr-TR",
                UniqueSeoCode = "tr",
                FlagImageFileName = "tr.png",
                Published = true,
                DisplayOrder = 0
            };

            Language enLanguage = new Language
            {
                Name = "English",
                LanguageCulture = "en-US",
                UniqueSeoCode = "en",
                FlagImageFileName = "us.png",
                Published = true,
                DisplayOrder = 1
            };
            context.Languages.Add(trLanguage);
            context.Languages.Add(enLanguage);

            FairUser fairUser = new FairUser
            {
                UserName = "admin",
                Password = "admin",
                IsActive = true
            };

            context.FairUsers.Add(fairUser);

            context.SaveChanges();
        }
    }
}
