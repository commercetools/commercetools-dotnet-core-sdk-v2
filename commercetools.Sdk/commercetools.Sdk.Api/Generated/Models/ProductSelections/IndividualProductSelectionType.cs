using commercetools.Sdk.Api.Models.Common;
using System;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class IndividualProductSelectionType : IIndividualProductSelectionType
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        public IProductSelectionTypeEnum Type { get; set; }

        public ILocalizedString Name { get; set; }
        public IndividualProductSelectionType()
        {
            this.Type = IProductSelectionTypeEnum.FindEnum("individual");
        }
    }
}
