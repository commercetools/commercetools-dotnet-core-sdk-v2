namespace commercetools.Api.Models.Errors
{
    public partial class EnumValueIsUsedError : IEnumValueIsUsedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public EnumValueIsUsedError()
        {
            this.Code = "EnumValueIsUsed";
        }
    }
}
