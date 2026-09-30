using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Sdk.Api.Models.Warnings;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentResponsesShoppingListSuccess : IAgentResponsesShoppingListSuccess
    {
        public IAgentResponsesOutputType EntityType { get; set; }

        public IList<IWarningObject> Warnings { get; set; }

        public IEnumerable<IWarningObject> WarningsEnumerable { set => Warnings = value.ToList(); }

        public string ThreadId { get; set; }

        public IShoppingList Entity { get; set; }
        public AgentResponsesShoppingListSuccess()
        {
            this.EntityType = IAgentResponsesOutputType.FindEnum("ShoppingList");
        }
    }
}
