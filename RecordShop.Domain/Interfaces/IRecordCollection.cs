namespace RecordShop.Domain
{
    using System;
    using System.Collections.Generic;

    interface IRecordCollection
    {
        List<Track> GetTrackList();
    }
}
