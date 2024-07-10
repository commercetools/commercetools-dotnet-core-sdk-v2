namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ContentTooLargeError : IContentTooLargeError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public ContentTooLargeError()
        {
            this.Code = "ContentTooLarge";
        }
    }
}
