using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.ProductSelections.VariantExclusion))]
    public partial interface IVariantExclusion
    {
        IList<string> Skus { get; set; }

        IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }

    }
}
