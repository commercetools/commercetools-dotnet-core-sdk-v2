namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class ObjectNotFoundError : IObjectNotFoundError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public ObjectNotFoundError()
        {
            this.Code = "ObjectNotFound";
        }
    }
}
