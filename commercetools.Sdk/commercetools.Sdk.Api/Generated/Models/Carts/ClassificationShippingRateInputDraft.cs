using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class ClassificationShippingRateInputDraft : IClassificationShippingRateInputDraft
    {
        public string Type { get; set; }

        public string Key { get; set; }
        public ClassificationShippingRateInputDraft()
        {
            this.Type = "Classification";
        }
    }
}
