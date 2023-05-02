using commercetools.Sdk.Api.Models.Common;
using System;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class IndividualExclusionProductSelectionType : IIndividualExclusionProductSelectionType
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        public IProductSelectionTypeEnum Type { get; set; }

        public ILocalizedString Name { get; set; }
        public IndividualExclusionProductSelectionType()
        {
            this.Type = IProductSelectionTypeEnum.FindEnum("individualExclusion");
        }
    }
}
