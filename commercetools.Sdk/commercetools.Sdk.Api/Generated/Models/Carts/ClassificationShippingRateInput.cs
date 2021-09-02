using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class ClassificationShippingRateInput : IClassificationShippingRateInput
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public ILocalizedString Label { get; set; }
        public ClassificationShippingRateInput()
        {
            this.Type = "Classification";
        }
    }
}
