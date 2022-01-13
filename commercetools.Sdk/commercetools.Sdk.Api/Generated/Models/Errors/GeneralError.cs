namespace commercetools.Api.Models.Errors
{
    public partial class GeneralError : IGeneralError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public GeneralError()
        {
            this.Code = "General";
        }
    }
}
