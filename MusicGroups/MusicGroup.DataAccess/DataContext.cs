namespace MusicGroup.DataAccess
{
    using MusicGroups.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
            Database.SetInitializer(new Initializer());
        }
        public virtual DbSet<Song> Songs{ get; set; }
        public virtual DbSet<MusicGroup> MusicGroups{ get; set; }  
    }
}