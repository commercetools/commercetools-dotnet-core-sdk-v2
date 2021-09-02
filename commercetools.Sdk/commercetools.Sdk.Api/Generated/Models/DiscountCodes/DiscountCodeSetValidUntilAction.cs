using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeSetValidUntilAction : IDiscountCodeSetValidUntilAction
    {
        public string Action { get; set; }

        public DateTime? ValidUntil { get; set; }
        public DiscountCodeSetValidUntilAction()
        {
            this.Action = "setValidUntil";
        }
    }
}
