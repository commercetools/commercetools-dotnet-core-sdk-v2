using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.UnauthorizedError))]
    public partial interface IUnauthorizedError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IList<string> StoresWithoutPermission { get; set; }

        IEnumerable<string> StoresWithoutPermissionEnumerable { set => StoresWithoutPermission = value.ToList(); }

    }
}
