namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class EnumValuesMustMatchError : IEnumValuesMustMatchError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public EnumValuesMustMatchError()
        {
            this.Code = "EnumValuesMustMatch";
        }
    }
}
