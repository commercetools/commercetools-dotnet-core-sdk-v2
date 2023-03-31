using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class IndividualExclusionProductSelectionType : IIndividualExclusionProductSelectionType
    {
        public IProductSelectionTypeEnum Type { get; set; }

        public ILocalizedString Name { get; set; }
        public IndividualExclusionProductSelectionType()
        {
            this.Type = IProductSelectionTypeEnum.FindEnum("individualExclusion");
        }
    }
}
