using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class DiscountCodeNonApplicableError : IDiscountCodeNonApplicableError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string DiscountCode { get; set; }

        public string Reason { get; set; }

        public string DiscountCodeId { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public DateTime? ValidityCheckTime { get; set; }
        public DiscountCodeNonApplicableError()
        {
            this.Code = "DiscountCodeNonApplicable";
        }
    }
}
