using System;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class ProductSelectionType : IProductSelectionType
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        public IProductSelectionTypeEnum Type { get; set; }
    }
}
