using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Agents
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Agents.AgentResponsesShoppingListSuccess))]
    public partial interface IAgentResponsesShoppingListSuccess : IAgentResponsesSuccess
    {
        IShoppingList Entity { get; set; }

    }
}
