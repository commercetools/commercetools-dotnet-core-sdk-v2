using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public abstract partial class OrderEditResult : IOrderEditResult
    {
        public string Type { get; set;}
    }
}
