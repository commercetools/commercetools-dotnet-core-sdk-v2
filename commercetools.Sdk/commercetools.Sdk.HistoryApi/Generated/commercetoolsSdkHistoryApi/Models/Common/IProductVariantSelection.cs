using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductVariantSelection))]
    public partial interface IProductVariantSelection
    {
        IProductVariantSelectionTypeEnum Type { get; set; }

        IList<string> Skus { get; set; }

        IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }

    }
}
