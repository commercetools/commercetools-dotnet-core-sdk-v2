namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class LockedFieldError : ILockedFieldError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string Field { get; set; }
        public LockedFieldError()
        {
            this.Code = "LockedField";
        }
    }
}
