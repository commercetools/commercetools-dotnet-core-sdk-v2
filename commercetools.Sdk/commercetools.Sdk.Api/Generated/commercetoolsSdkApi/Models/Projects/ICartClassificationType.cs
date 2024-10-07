using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.CartClassificationType))]
    public partial interface ICartClassificationType : IShippingRateInputType
    {
        IList<ICustomFieldLocalizedEnumValue> Values { get; set; }

        IEnumerable<ICustomFieldLocalizedEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

    }
}
