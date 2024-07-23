namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class MaxStoreReferencesReachedError : IMaxStoreReferencesReachedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public MaxStoreReferencesReachedError()
        {
            this.Code = "MaxStoreReferencesReached";
        }
    }
}
