using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductVariantExclusion))]
    public partial interface IProductVariantExclusion
    {
        IList<string> Skus { get; set; }

        IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }

    }
}
