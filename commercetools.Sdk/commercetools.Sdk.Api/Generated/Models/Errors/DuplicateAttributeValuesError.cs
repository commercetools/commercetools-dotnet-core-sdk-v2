using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class DuplicateAttributeValuesError : IDuplicateAttributeValuesError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public List<IAttribute> Attributes { get; set; }
        public DuplicateAttributeValuesError()
        {
            this.Code = "DuplicateAttributeValues";
        }
    }
}
