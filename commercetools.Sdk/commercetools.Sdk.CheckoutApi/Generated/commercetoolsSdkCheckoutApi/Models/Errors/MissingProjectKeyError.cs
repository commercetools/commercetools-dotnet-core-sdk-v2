

namespace commercetools.Sdk.CheckoutApi.Models.Errors
{

    public partial class MissingProjectKeyError : IMissingProjectKeyError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public MissingProjectKeyError()
        {
            this.Code = "MissingProjectKey";
        }
    }
}
