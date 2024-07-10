using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ErrorByExtension))]
    public partial interface IErrorByExtension
    {
        string Id { get; set; }

        string Key { get; set; }

    }
}
