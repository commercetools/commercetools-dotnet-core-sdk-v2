using commercetools.Sdk.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeSetValidFromAction : IDiscountCodeSetValidFromAction
    {
        public string Action { get; set; }

        public DateTime? ValidFrom { get; set; }
        public DiscountCodeSetValidFromAction()
        {
            this.Action = "setValidFrom";
        }
    }
}
