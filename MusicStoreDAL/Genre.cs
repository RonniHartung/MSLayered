using System.Collections.Generic;

namespace MusicStoreDAL
{
    public class Genre
    {
        public string Name { get; set; }
        public int Id { get; set; }

        // The navigation property below must be declared as virtual because
        // EF must override it in order to make the navigation work.
        public virtual List<Album> Albums { get; set; }
    }
}