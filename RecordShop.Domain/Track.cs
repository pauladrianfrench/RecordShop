namespace RecordShop.Domain
{
    using System;

    public class Track
    {
        public Decimal Price { get; set; }
        public string  Name { get; set; }
        public Artist Artist { get; set; }
    }
}
