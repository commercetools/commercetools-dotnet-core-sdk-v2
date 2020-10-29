using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public abstract partial class DiscountCodeUpdateAction : IDiscountCodeUpdateAction
    {
        public string Action { get; set;}
    }
}
