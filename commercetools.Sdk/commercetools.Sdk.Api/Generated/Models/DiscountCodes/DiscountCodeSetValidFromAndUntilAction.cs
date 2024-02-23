using System;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeSetValidFromAndUntilAction : IDiscountCodeSetValidFromAndUntilAction
    {
        public string Action { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }
        public DiscountCodeSetValidFromAndUntilAction()
        {
            this.Action = "setValidFromAndUntil";
        }
    }
}
