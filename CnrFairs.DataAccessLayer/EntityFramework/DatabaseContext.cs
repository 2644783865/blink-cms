using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CnrFairs.Entities;

namespace CnrFairs.DataAccessLayer.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Language> Languages { get; set; }
        public DbSet<Fair> Fairs { get; set; }
        public DbSet<FairUser> FairUsers { get; set; }
        public DbSet<FairDetail> FairDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentWithEmployee> DepartmentWithEmployees { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityInstructor> ActivityInstructors { get; set; }
        public DbSet<PressRelease> PressReleases { get; set; }
        public DbSet<PhotoMedia> PhotoMedias { get; set; }
        public DbSet<VideoMedia> VideoMedias { get; set; }
        public DbSet<Logo> Logos { get; set; }
        public DbSet<GoogleAnalytics> GoogleAnalytics { get; set; }
        public DbSet<SocialAccount> SocialAccounts { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<FairCeo> FairCeos { get; set; }
        public DbSet<Tabs> Tabs { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<ContactFormMailAdress> GetContactFormMailAdresses { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderTitleLocation> SliderTitleLocations { get; set; }
        public DbSet<FairInfo> FairInfos { get; set; }
        public DbSet<FairGround> FairGrounds { get; set; }
        public DbSet<Transportation> Transportations { get; set; }
        public DbSet<ExhibitorProfile> ExhibitorProfiles { get; set; }
        public DbSet<VisitorProfile> VisitorProfiles { get; set; }
        public DbSet<EmailAccount> EmailAccounts { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<ActivityLogType> ActivityLogTypes { get; set; }
        public DbSet<Topic> Topics { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new MyInitializer());
        }
    }
}
