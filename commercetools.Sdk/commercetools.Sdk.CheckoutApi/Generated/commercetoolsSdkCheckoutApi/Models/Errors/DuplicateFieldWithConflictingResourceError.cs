

namespace commercetools.Sdk.CheckoutApi.Models.Errors
{

    public partial class DuplicateFieldWithConflictingResourceError : IDuplicateFieldWithConflictingResourceError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public DuplicateFieldWithConflictingResourceError()
        {
            this.Code = "DuplicateFieldWithConflictingResource";
        }
    }
}
