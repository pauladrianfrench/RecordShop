namespace RecordShop.Web
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Reflection;

    public class ViewModelMapper
    {
        public void Map<TSource, TDestination>(TSource source, TDestination dest)
        {
            Type tSource = source.GetType();

            foreach (var p in typeof(TSource).GetProperties())
            {
                PropertyInfo dProp = dest.GetType().GetProperty(p.Name);
                if (dProp != null && dProp.CanWrite && p.CanRead)
                {
                    dProp.SetValue(dest, p.GetValue(source, null), null);
                }
            }
        }
    }
}