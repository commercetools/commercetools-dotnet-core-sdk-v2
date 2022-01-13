namespace commercetools.Api.Models.Errors
{
    public partial class NotEnabledError : INotEnabledError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public NotEnabledError()
        {
            this.Code = "NotEnabled";
        }
    }
}
