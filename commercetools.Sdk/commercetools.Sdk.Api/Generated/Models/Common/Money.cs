using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public  partial class Money : IMoney
    {
        public long CentAmount { get; set;}
        
        public string CurrencyCode { get; set;}
    }
}
