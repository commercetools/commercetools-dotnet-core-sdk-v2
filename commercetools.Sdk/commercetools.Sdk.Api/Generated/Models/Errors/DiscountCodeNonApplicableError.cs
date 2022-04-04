using System;


namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class DiscountCodeNonApplicableError : IDiscountCodeNonApplicableError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string DiscountCode { get; set; }

        public string Reason { get; set; }

        public string DicountCodeId { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public DateTime? ValidityCheckTime { get; set; }
        public DiscountCodeNonApplicableError()
        {
            this.Code = "DiscountCodeNonApplicable";
        }
    }
}
