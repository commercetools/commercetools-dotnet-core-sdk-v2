using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeDraft))]
    public partial interface IProductTypeDraft
    {
        string Key { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        IList<IAttributeDefinitionDraft> Attributes { get; set; }
        IEnumerable<IAttributeDefinitionDraft> AttributesEnumerable { set => Attributes = value.ToList(); }


    }
}
