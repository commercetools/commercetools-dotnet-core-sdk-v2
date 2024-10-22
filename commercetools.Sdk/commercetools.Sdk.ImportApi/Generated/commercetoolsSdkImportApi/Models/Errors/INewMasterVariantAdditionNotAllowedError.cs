using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.NewMasterVariantAdditionNotAllowedError))]
    public partial interface INewMasterVariantAdditionNotAllowedError : IErrorObject
    {
        new string Message { get; set; }

    }
}
