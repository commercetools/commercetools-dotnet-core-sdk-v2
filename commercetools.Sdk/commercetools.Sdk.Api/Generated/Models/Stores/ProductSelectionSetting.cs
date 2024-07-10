using commercetools.Sdk.Api.Models.ProductSelections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class ProductSelectionSetting : IProductSelectionSetting
    {
        public IProductSelectionReference ProductSelection { get; set; }

        public bool Active { get; set; }
    }
}
