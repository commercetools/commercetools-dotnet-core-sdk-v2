using commercetools.Sdk.Api.Models.ProductTailorings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringUnpublishAction : IProductTailoringUnpublishAction
    {
        public string Action { get; set; }
        public ProductTailoringUnpublishAction()
        {
            this.Action = "unpublish";
        }
    }
}
