using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCMusicStoreCodeFirst.DAL
{
    public class MusicStoreDB : DbContext
    {
        public MusicStoreDB() : base("name=MusicStoreDB")
        {
        }

        public System.Data.Entity.DbSet<MVCMusicStoreCodeFirst.Models.Album> Albums { get; set; }

        public System.Data.Entity.DbSet<MVCMusicStoreCodeFirst.Models.Artist> Artists { get; set; }

        public System.Data.Entity.DbSet<MVCMusicStoreCodeFirst.Models.Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<MVCMusicStoreCodeFirst.Models.Order> Orders { get; set; }

    }
}