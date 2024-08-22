using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.ReferencedResourceNotFound))]
    public partial interface IReferencedResourceNotFound : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IReferenceType TypeId { get; set; }

        string Id { get; set; }

        string Key { get; set; }

    }
}
