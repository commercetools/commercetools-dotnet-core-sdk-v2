using commercetools.Sdk.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeChangeInputHintAction : IProductTypeChangeInputHintAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public ITextInputHint NewValue { get; set; }
        public ProductTypeChangeInputHintAction()
        {
            this.Action = "changeInputHint";
        }
    }
}
