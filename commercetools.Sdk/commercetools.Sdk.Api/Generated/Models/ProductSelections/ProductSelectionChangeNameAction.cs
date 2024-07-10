using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductSelections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelectionChangeNameAction : IProductSelectionChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public ProductSelectionChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
