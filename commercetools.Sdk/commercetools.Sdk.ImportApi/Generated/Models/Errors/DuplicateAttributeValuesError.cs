using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Errors
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
