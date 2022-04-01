namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class EnumKeyDoesNotExistError : IEnumKeyDoesNotExistError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string ConflictingEnumKey { get; set; }

        public string ConflictingAttributeName { get; set; }
        public EnumKeyDoesNotExistError()
        {
            this.Code = "EnumKeyDoesNotExist";
        }
    }
}
