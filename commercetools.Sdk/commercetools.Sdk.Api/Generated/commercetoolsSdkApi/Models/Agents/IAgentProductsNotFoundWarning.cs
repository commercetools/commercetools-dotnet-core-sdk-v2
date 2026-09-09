using commercetools.Sdk.Api.Models.Warnings;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Agents
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Agents.AgentProductsNotFoundWarning))]
    public partial interface IAgentProductsNotFoundWarning : IWarningObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IList<string> Products { get; set; }

        IEnumerable<string> ProductsEnumerable { set => Products = value.ToList(); }

    }
}
