using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantUpdate))]
    public partial interface IVariantUpdate
    {
        long Version { get; set; }

        IList<IVariantUpdateAction> Actions { get; set; }

        IEnumerable<IVariantUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
