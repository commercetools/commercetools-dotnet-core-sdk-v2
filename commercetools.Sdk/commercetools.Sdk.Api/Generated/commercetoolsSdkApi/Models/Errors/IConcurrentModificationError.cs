using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ConcurrentModificationError))]
    public partial interface IConcurrentModificationError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        long? CurrentVersion { get; set; }

    }
}
