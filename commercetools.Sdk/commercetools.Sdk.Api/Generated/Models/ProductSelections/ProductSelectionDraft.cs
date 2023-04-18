using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelectionDraft : IProductSelectionDraft
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public IProductSelectionTypeEnum Type { get; set; }

        public IProductSelectionMode Mode { get; set; }
    }
}
