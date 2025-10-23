using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ExcludeProductChange : IExcludeProductChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IProductVariantExclusion VariantExclusion { get; set; }

        public IReference NextValue { get; set; }
        public ExcludeProductChange()
        {
            this.Type = "ExcludeProductChange";
        }
    }
}
