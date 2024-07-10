using commercetools.Sdk.Api.Models.ProductSelections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class ProductSelectionSettingDraft : IProductSelectionSettingDraft
    {
        public IProductSelectionResourceIdentifier ProductSelection { get; set; }

        public bool? Active { get; set; }
    }
}
