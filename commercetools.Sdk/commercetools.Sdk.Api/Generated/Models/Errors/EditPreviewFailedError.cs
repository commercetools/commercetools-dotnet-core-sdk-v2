using commercetools.Sdk.Api.Models.OrderEdits;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class EditPreviewFailedError : IEditPreviewFailedError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IOrderEditPreviewFailure Result { get; set; }
        public EditPreviewFailedError()
        {
            this.Code = "EditPreviewFailed";
        }
    }
}
