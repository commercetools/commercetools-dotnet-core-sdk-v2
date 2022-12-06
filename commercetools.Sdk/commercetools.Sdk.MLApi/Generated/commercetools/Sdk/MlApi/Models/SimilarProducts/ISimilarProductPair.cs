using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.SimilarProducts.SimilarProductPair))]
    public partial interface ISimilarProductPair
    {
        decimal Confidence { get; set; }

        IList<ISimilarProduct> Products { get; set; }
        IEnumerable<ISimilarProduct> ProductsEnumerable { set => Products = value.ToList(); }


    }
}
