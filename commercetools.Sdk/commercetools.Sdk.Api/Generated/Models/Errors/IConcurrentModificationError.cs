using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ConcurrentModificationError))]
    public partial interface IConcurrentModificationError : IErrorObject
    {
        long? CurrentVersion { get; set; }

    }
}
