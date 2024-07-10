using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class DuplicateEnumValuesError : IDuplicateEnumValuesError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IList<string> Duplicates { get; set; }
        public IEnumerable<string> DuplicatesEnumerable { set => Duplicates = value.ToList(); }

        public DuplicateEnumValuesError()
        {
            this.Code = "DuplicateEnumValues";
        }
    }
}
