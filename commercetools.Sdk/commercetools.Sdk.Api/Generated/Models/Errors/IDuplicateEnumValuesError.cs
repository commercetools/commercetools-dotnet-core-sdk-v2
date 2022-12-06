using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DuplicateEnumValuesError))]
    public partial interface IDuplicateEnumValuesError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IList<string> Duplicates { get; set; }
        IEnumerable<string> DuplicatesEnumerable { set => Duplicates = value.ToList(); }


    }
}
