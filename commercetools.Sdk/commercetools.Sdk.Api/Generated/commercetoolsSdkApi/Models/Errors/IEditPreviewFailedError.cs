using commercetools.Sdk.Api.Models.OrderEdits;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.EditPreviewFailedError))]
    public partial interface IEditPreviewFailedError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IOrderEditPreviewFailure Result { get; set; }

    }
}
