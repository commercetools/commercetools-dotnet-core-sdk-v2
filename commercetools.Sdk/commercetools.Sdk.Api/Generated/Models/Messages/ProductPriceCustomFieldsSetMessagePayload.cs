using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPriceCustomFieldsSetMessagePayload : IProductPriceCustomFieldsSetMessagePayload
    {
        public string Type { get; set; }

        public string PriceId { get; set; }

        public long VariantId { get; set; }

        public bool Staged { get; set; }

        public ICustomFields CustomField { get; set; }

        public string OldTypeId { get; set; }
        public ProductPriceCustomFieldsSetMessagePayload()
        {
            this.Type = "ProductPriceCustomFieldsSet";
        }
    }
}
