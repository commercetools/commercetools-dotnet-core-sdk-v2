namespace commercetools.Sdk.ImportApi.Models.Errors
{
    public partial class InvalidInput : IInvalidInput
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public InvalidInput()
        {
            this.Code = "InvalidInput";
        }
    }
}
