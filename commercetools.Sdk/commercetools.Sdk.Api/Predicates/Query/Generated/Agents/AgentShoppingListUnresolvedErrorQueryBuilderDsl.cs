// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentShoppingListUnresolvedErrorQueryBuilderDsl
    {
        public AgentShoppingListUnresolvedErrorQueryBuilderDsl()
        {
        }

        public static AgentShoppingListUnresolvedErrorQueryBuilderDsl Of()
        {
            return new AgentShoppingListUnresolvedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentShoppingListUnresolvedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentShoppingListUnresolvedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentShoppingListUnresolvedErrorQueryBuilderDsl>(p, AgentShoppingListUnresolvedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentShoppingListUnresolvedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentShoppingListUnresolvedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentShoppingListUnresolvedErrorQueryBuilderDsl>(p, AgentShoppingListUnresolvedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
