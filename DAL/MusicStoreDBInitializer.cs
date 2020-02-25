using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCMusicStoreCodeFirst.Models;

namespace MVCMusicStoreCodeFirst.DAL
{
    public class MusicStoreDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            var Artist = new List<Artist>
            {
                new Artist{Name="Panic at the Disco"},
                new Artist{Name="Imagine Dragons"},
                new Artist{Name="Greta Van Fleet"},
                new Artist{Name="Twenty One Pilots"},
                new Artist{Name="Rolling Stones"},
                new Artist{Name="Led Zepplin"},
                new Artist{Name="Cheap Trick"},
                new Artist{Name="Pink"},
                new Artist{Name="Bob Marley and the Wailers"},
                new Artist{Name="Sabaton"},
                new Artist{Name="Fleetwood Mac"}
            };
            Artist.ForEach(a => context.Artists.Add(a));
            context.SaveChanges();

            var Genre = new List<Genre>
            {
                new Genre{Name="Alternative"},
                new Genre{Name="Blues"},
                new Genre{Name="Classical"},
                new Genre{Name="Country"},
                new Genre{Name="Dance"},
                new Genre{Name="Electronic"},
                new Genre{Name="Hip Hop"},
                new Genre{Name="Jazz"},
                new Genre{Name="Metal"},
                new Genre{Name="Pop"},
                new Genre{Name="R&B/Soul"},
                new Genre{Name="Raggae"},
                new Genre{Name="Rock"}
            };
            Genre.ForEach(g => context.Genres.Add(g));
            context.SaveChanges();

            var Album = new List<Album>
            {
                new Album{GenreId=1 ,  ArtistId=1  ,Title="Pray for the Wicked" , Price=9.99m , AlbumArtUrl=""},
                new Album{GenreId=1 ,  ArtistId=1  ,Title="Death of a Bachelor" , Price=7.99m , AlbumArtUrl=""},
                new Album{GenreId=1 ,  ArtistId=2  ,Title="Origins" , Price=11.99m , AlbumArtUrl=""},
                new Album{GenreId=1 ,  ArtistId=2  ,Title="Evolve" , Price=9.99m , AlbumArtUrl=""},
                new Album{GenreId=13 ,  ArtistId=3  ,Title="From the Fires" , Price=6.99m , AlbumArtUrl=""},
                new Album{GenreId=13 ,  ArtistId=3  ,Title="Anthem of the Peaceful Army" , Price=6.99m , AlbumArtUrl=""},
                new Album{GenreId=13 ,  ArtistId=5  ,Title="Hot Rocks 1964-1971" , Price=14.99m , AlbumArtUrl=""},
                new Album{GenreId=13 ,  ArtistId=11  ,Title="Rumours" , Price=6.99m , AlbumArtUrl=""},
        new Album{GenreId=13 ,  ArtistId=10  ,Title="The Great War" , Price=11.39m , AlbumArtUrl="https://www.amazon.com/Great-War-CD-Sabaton/dp/B07R9HX3KZ"},
                new Album{GenreId=12 ,  ArtistId=9  ,Title="Legend" , Price=9.99m , AlbumArtUrl=""},
                new Album{GenreId=12 ,  ArtistId=9  ,Title="Exodus" , Price=7.99m , AlbumArtUrl=""},
                new Album{GenreId=13 ,  ArtistId=7  ,Title="Authorized Greatest Hits" , Price=10.99m , AlbumArtUrl=""},
            };
            Album.ForEach(a => context.Albums.Add(a));
            context.SaveChanges();

        }
    }
}