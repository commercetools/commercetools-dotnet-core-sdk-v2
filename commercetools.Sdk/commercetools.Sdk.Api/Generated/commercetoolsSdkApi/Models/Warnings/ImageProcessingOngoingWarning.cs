

namespace commercetools.Sdk.Api.Models.Warnings
{

    public partial class ImageProcessingOngoingWarning : IImageProcessingOngoingWarning
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public ImageProcessingOngoingWarning()
        {
            this.Code = "ImageProcessingOngoing";
        }
    }
}
