using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    public partial class IndividualProductSelectionType : IIndividualProductSelectionType
    {
        public IProductSelectionTypeEnum Type { get; set; }

        public ILocalizedString Name { get; set; }
        public IndividualProductSelectionType()
        {
            this.Type = IProductSelectionTypeEnum.FindEnum("individual");
        }
    }
}
