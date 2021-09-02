using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeChangeIsActiveAction : IDiscountCodeChangeIsActiveAction
    {
        public string Action { get; set; }

        public bool IsActive { get; set; }
        public DiscountCodeChangeIsActiveAction()
        {
            this.Action = "changeIsActive";
        }
    }
}
