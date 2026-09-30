// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentMissingShoppingListNameErrorQueryBuilderDsl
    {
        public AgentMissingShoppingListNameErrorQueryBuilderDsl()
        {
        }

        public static AgentMissingShoppingListNameErrorQueryBuilderDsl Of()
        {
            return new AgentMissingShoppingListNameErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentMissingShoppingListNameErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentMissingShoppingListNameErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentMissingShoppingListNameErrorQueryBuilderDsl>(p, AgentMissingShoppingListNameErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentMissingShoppingListNameErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentMissingShoppingListNameErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentMissingShoppingListNameErrorQueryBuilderDsl>(p, AgentMissingShoppingListNameErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
