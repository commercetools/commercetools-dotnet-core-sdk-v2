// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentShoppingListCreationFailedErrorQueryBuilderDsl
    {
        public AgentShoppingListCreationFailedErrorQueryBuilderDsl()
        {
        }

        public static AgentShoppingListCreationFailedErrorQueryBuilderDsl Of()
        {
            return new AgentShoppingListCreationFailedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentShoppingListCreationFailedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentShoppingListCreationFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentShoppingListCreationFailedErrorQueryBuilderDsl>(p, AgentShoppingListCreationFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentShoppingListCreationFailedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentShoppingListCreationFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentShoppingListCreationFailedErrorQueryBuilderDsl>(p, AgentShoppingListCreationFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
