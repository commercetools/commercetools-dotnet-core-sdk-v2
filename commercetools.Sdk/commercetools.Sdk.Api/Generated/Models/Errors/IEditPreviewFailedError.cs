using commercetools.Api.Models.OrderEdits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.EditPreviewFailedError))]
    public partial interface IEditPreviewFailedError : IErrorObject
    {
        IOrderEditPreviewFailure Result { get; set;}
    }
}
