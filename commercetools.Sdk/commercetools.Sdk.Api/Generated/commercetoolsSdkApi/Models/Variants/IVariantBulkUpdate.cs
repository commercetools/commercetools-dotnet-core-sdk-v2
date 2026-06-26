using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantBulkUpdate))]
    public partial interface IVariantBulkUpdate
    {
        IList<IVariantBulkUpdateItem> Items { get; set; }

        IEnumerable<IVariantBulkUpdateItem> ItemsEnumerable { set => Items = value.ToList(); }

        IList<IVariantUpdateAction> Actions { get; set; }

        IEnumerable<IVariantUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
