using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.ProductSelectionReference))]
    public partial interface IProductSelectionReference : IReference
    {
        new string Id { get; set; }

        IProductSelection Obj { get; set; }
    }
}
