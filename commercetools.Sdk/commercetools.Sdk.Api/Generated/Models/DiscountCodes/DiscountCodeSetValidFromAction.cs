using System;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeSetValidFromAction : IDiscountCodeSetValidFromAction
    {
        public string Action { get; set; }

        public DateTime? ValidFrom { get; set; }
        public DiscountCodeSetValidFromAction()
        {
            this.Action = "setValidFrom";
        }
    }
}
