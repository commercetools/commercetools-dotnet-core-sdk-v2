using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetVariantExclusionChange : ISetVariantExclusionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IReference Product { get; set; }

        public IProductVariantExclusion PreviousValue { get; set; }

        public IProductVariantExclusion NextValue { get; set; }
        public SetVariantExclusionChange()
        {
            this.Type = "SetVariantExclusionChange";
        }
    }
}
