﻿using SwamaanShaadi.DomainClasses;
using System.Data.Entity;
using System;

namespace SwamaanShaadi.DataLayer
{
    public class MembersContext : DbContext
    {
        public MembersContext() : base("name=TestDb")
        {
            //Database.SetInitializer(new MemberDbInitializer());
            Database.SetInitializer<MembersContext>(null);
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<AccountStatus> AllAccountStatus { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<Caste> Castes { get; set; }
        public DbSet<HomeState> HomeStates { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Education> EducationQualifications { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<ProfileFor> AllProfileFor { get; set; }
        public DbSet<MemberPhotograph> MemberPhotographs { get; set; }

        public DbSet<MatchHistory> MatchHistory { get; set; }

        public DbSet<PartnerCaste> PartnerCaste { get; set; }
        public DbSet<PartnerDistrict> PartnerDistrict { get; set; }
        public DbSet<PartnerEducation> PartnerEducation { get; set; }
        public DbSet<PartnerMaritalStatus> PartnerMaritalStatus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new AccountStatusMap());
            modelBuilder.Configurations.Add(new ReligionMap());
            modelBuilder.Configurations.Add(new CasteMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new DistrictMap());
            modelBuilder.Configurations.Add(new GenderMap());
            modelBuilder.Configurations.Add(new EducationMap());
            modelBuilder.Configurations.Add(new EmploymentTypeMap());
            modelBuilder.Configurations.Add(new MaritalStatusMap());
            modelBuilder.Configurations.Add(new ProfileForMap());
            modelBuilder.Configurations.Add(new MemberPhotographMap());
            modelBuilder.Configurations.Add(new MatchHistoryMap());

            modelBuilder.Configurations.Add(new PartnerDistrictMap());
            modelBuilder.Configurations.Add(new PartnerCasteMap());
            modelBuilder.Configurations.Add(new PartnerEducationMap());
            modelBuilder.Configurations.Add(new PartnerMaritalStatusMap());
        }
    }
}
