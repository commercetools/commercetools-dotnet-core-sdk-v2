using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class OutOfStockError : IOutOfStockError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public List<string> LineItems { get; set; }

        public List<string> Skus { get; set; }
        public OutOfStockError()
        {
            this.Code = "OutOfStock";
        }
    }
}
