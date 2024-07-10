namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class InvalidSubjectError : IInvalidSubjectError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public InvalidSubjectError()
        {
            this.Code = "InvalidSubject";
        }
    }
}
