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

    public partial class DiscountCodeSetNameAction : IDiscountCodeSetNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public DiscountCodeSetNameAction()
        {
            this.Action = "setName";
        }
    }
}
