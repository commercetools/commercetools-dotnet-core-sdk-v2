using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Warnings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Warnings.ImageProcessingOngoingWarning))]
    public partial interface IImageProcessingOngoingWarning : IWarningObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
