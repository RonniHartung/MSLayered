using System;

namespace MusicStoreDAL
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public string SongSampleUrl { get; set; }
        public DateTime ReleaseDate { get; set; }

        // Foreign key properties.
        // These properties are not strictly necessary, if the class has
        // navigation propperties, but they have their advantages. If they
        // are not present, the scaffolded AlbumsController and it's views
        // will have no knowledge about an associated Artist and Genre.
        public int ArtistId { get; set; }
        public int GenreId { get; set; }

        // The navigation properties below must be declared as virtual because
        // EF must override them in order to make the navigation work.
        public virtual Artist Artist { get; set; }
        public virtual Genre Genre { get; set; }
    }
}