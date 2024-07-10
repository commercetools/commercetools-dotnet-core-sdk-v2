using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelectionDraft : IProductSelectionDraft
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IProductSelectionMode Mode { get; set; }
    }
}
