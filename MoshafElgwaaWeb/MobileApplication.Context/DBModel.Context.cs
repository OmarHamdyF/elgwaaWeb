﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobileApplication.Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class QVMobileApplicationEntities : DbContext
    {
        public QVMobileApplicationEntities()
            : base("name=QVMobileApplicationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AppSetting> AppSetting { get; set; }
        public DbSet<ArticleItemExplanation> ArticleItemExplanation { get; set; }
        public DbSet<Ayah> Ayah { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Content> Content { get; set; }
        public DbSet<ContentCategory> ContentCategory { get; set; }
        public DbSet<CU_Action> CU_Action { get; set; }
        public DbSet<CU_Branch> CU_Branch { get; set; }
        public DbSet<CU_Department> CU_Department { get; set; }
        public DbSet<CU_Employee> CU_Employee { get; set; }
        public DbSet<CU_Employee_Role> CU_Employee_Role { get; set; }
        public DbSet<CU_Employee_RoleProgram> CU_Employee_RoleProgram { get; set; }
        public DbSet<CU_EmployeeCategory> CU_EmployeeCategory { get; set; }
        public DbSet<CU_HeadDepartment> CU_HeadDepartment { get; set; }
        public DbSet<CU_Job> CU_Job { get; set; }
        public DbSet<CU_Log> CU_Log { get; set; }
        public DbSet<CU_Page> CU_Page { get; set; }
        public DbSet<CU_Program> CU_Program { get; set; }
        public DbSet<CU_Role> CU_Role { get; set; }
        public DbSet<CU_Role_Page> CU_Role_Page { get; set; }
        public DbSet<CU_Role_Program> CU_Role_Program { get; set; }
        public DbSet<DaysOfWeek> DaysOfWeek { get; set; }
        public DbSet<DoaaMainCategory> DoaaMainCategory { get; set; }
        public DbSet<ExceptionLog> ExceptionLog { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<GroupTarget> GroupTarget { get; set; }
        public DbSet<GroupUser> GroupUser { get; set; }
        public DbSet<Juz> Juz { get; set; }
        public DbSet<MailEngine> MailEngine { get; set; }
        public DbSet<Moshaf> Moshaf { get; set; }
        public DbSet<Nationality> Nationality { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<NotificationType> NotificationType { get; set; }
        public DbSet<NotificationUser> NotificationUser { get; set; }
        public DbSet<PeriodType> PeriodType { get; set; }
        public DbSet<PushNotificationLog> PushNotificationLog { get; set; }
        public DbSet<ResetPasswordRequest> ResetPasswordRequest { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<SMS_Config> SMS_Config { get; set; }
        public DbSet<SMS_ConfigParam> SMS_ConfigParam { get; set; }
        public DbSet<SMS_Message> SMS_Message { get; set; }
        public DbSet<Surah> Surah { get; set; }
        public DbSet<TargetType> TargetType { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserAyat> UserAyat { get; set; }
        public DbSet<UserCode> UserCode { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<Doaa> Doaa { get; set; }
        public DbSet<NamesOfAllah> NamesOfAllah { get; set; }
        public DbSet<DoaaItemSource> DoaaItemSource { get; set; }
        public DbSet<DoaaContent> DoaaContent { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
    
        public virtual ObjectResult<TableRef_Result> TableRef(string table)
        {
            var tableParameter = table != null ?
                new ObjectParameter("table", table) :
                new ObjectParameter("table", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TableRef_Result>("TableRef", tableParameter);
        }
    }
}
