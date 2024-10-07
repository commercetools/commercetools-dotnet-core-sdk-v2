using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidFieldsUpdateError))]
    public partial interface IInvalidFieldsUpdateError : IErrorObject
    {
        new string Message { get; set; }

        IList<string> Fields { get; set; }

        IEnumerable<string> FieldsEnumerable { set => Fields = value.ToList(); }

    }
}
