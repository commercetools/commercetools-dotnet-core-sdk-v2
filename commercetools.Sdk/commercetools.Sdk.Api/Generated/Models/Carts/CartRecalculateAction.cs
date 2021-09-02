using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartRecalculateAction : ICartRecalculateAction
    {
        public string Action { get; set; }

        public bool? UpdateProductData { get; set; }
        public CartRecalculateAction()
        {
            this.Action = "recalculate";
        }
    }
}
