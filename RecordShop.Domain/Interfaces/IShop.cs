namespace RecordShop.Domain
{
    using System;
    using System.Collections.Generic;

    interface IShop
    {
        List<Track> GetTrackList();
    }
}
