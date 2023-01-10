using System;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class AssignedProductSelection : IAssignedProductSelection
    {
        public IProductSelectionReference ProductSelection { get; set; }

        public IProductVariantSelection VariantSelection { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
