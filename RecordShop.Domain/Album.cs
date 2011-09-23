namespace RecordShop.Domain
{
    using System;
    using System.Collections.Generic;

    public class IAlbum
    {
        string Name { get; set; }
        List<Track> Tracks { get; set; }
    }
}
