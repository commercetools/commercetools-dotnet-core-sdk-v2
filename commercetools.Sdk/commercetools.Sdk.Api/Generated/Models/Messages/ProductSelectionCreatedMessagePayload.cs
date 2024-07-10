using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.ProductSelections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductSelectionCreatedMessagePayload : IProductSelectionCreatedMessagePayload
    {
        public string Type { get; set; }

        public IProductSelection ProductSelection { get; set; }
        public ProductSelectionCreatedMessagePayload()
        {
            this.Type = "ProductSelectionCreated";
        }
    }
}
