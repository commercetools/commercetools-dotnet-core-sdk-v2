namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class WeakPasswordError : IWeakPasswordError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public WeakPasswordError()
        {
            this.Code = "WeakPassword";
        }
    }
}
