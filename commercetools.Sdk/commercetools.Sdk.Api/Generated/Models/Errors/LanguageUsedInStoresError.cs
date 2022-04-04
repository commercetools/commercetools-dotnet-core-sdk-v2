namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class LanguageUsedInStoresError : ILanguageUsedInStoresError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public LanguageUsedInStoresError()
        {
            this.Code = "LanguageUsedInStores";
        }
    }
}
