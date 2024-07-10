using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeSetInputTipAction : IProductTypeSetInputTipAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public ILocalizedString InputTip { get; set; }
        public ProductTypeSetInputTipAction()
        {
            this.Action = "setInputTip";
        }
    }
}
