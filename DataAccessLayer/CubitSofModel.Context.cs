﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class cubitEntities : DbContext
    {
        public cubitEntities()
            : base("name=cubitEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<authtoken> authtokens { get; set; }
        public DbSet<city> cities { get; set; }
        public DbSet<@class> classes { get; set; }
        public DbSet<country> countries { get; set; }
        public DbSet<friend> friends { get; set; }
        public DbSet<gpslocation> gpslocations { get; set; }
        public DbSet<group> groups { get; set; }
        public DbSet<instclssectionmapping> instclssectionmappings { get; set; }
        public DbSet<parent> parents { get; set; }
        public DbSet<post> posts { get; set; }
        public DbSet<requeststatu> requeststatus { get; set; }
        public DbSet<section> sections { get; set; }
        public DbSet<sectsubjmapping> sectsubjmappings { get; set; }
        public DbSet<state> states { get; set; }
        public DbSet<subject> subjects { get; set; }
        public DbSet<usergroup> usergroups { get; set; }
        public DbSet<userinfo> userinfoes { get; set; }
        public DbSet<userpersonalinfo> userpersonalinfoes { get; set; }
        public DbSet<document> documents { get; set; }
        public DbSet<eventpost> eventposts { get; set; }
        public DbSet<teacher> teachers { get; set; }
        public DbSet<timetable> timetables { get; set; }
        public DbSet<periodtimetable> periodtimetables { get; set; }
        public DbSet<examreportmapping> examreportmappings { get; set; }
        public DbSet<examschedule> examschedules { get; set; }
        public DbSet<homeworkupload> homeworkuploads { get; set; }
        public DbSet<quizquestion> quizquestions { get; set; }
        public DbSet<quizresult> quizresults { get; set; }
        public DbSet<homework> homework { get; set; }
        public DbSet<reportcard> reportcards { get; set; }
        public DbSet<student> students { get; set; }
        public DbSet<institution> institutions { get; set; }
    }
}
