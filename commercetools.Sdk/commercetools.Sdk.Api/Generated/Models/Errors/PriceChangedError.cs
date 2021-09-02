using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class PriceChangedError : IPriceChangedError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public List<string> LineItems { get; set; }

        public bool Shipping { get; set; }
        public PriceChangedError()
        {
            this.Code = "PriceChanged";
        }
    }
}
