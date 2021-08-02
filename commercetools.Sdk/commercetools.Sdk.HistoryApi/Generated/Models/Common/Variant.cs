using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class Variant : IVariant
    {
        public int Id { get; set;}
        
        public string Sku { get; set;}
        
        public string Key { get; set;}
    }
}
