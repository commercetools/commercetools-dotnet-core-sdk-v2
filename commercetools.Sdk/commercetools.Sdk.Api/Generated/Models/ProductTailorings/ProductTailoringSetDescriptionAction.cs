using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTailorings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetDescriptionAction : IProductTailoringSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
