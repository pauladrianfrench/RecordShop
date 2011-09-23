namespace RecordShop.Domain
{
    using System;
    using System.Collections.Generic;

    public class Customer
    {
         Person Person { get; set; }
         IRecordCollection RecordCollection { get; set; }
    }
}
