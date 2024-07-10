using commercetools.Sdk.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Errors
{

    public partial class DuplicateVariantValuesError : IDuplicateVariantValuesError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IVariantValues VariantValues { get; set; }
        public DuplicateVariantValuesError()
        {
            this.Code = "DuplicateVariantValues";
        }
    }
}
