using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Errors.ConcurrentModificationError))]
    public partial interface IConcurrentModificationError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string ResourceId { get; set; }

        long ExpectedVersion { get; set; }

        long CurrentVersion { get; set; }

    }
}
