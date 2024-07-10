using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeSetDescriptionAction : IDiscountCodeSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public DiscountCodeSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
