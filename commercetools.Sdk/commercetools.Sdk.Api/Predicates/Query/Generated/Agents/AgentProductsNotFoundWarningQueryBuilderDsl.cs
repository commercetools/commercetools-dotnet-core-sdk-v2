// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentProductsNotFoundWarningQueryBuilderDsl
    {
        public AgentProductsNotFoundWarningQueryBuilderDsl()
        {
        }

        public static AgentProductsNotFoundWarningQueryBuilderDsl Of()
        {
            return new AgentProductsNotFoundWarningQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentProductsNotFoundWarningQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentProductsNotFoundWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentProductsNotFoundWarningQueryBuilderDsl>(p, AgentProductsNotFoundWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentProductsNotFoundWarningQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentProductsNotFoundWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentProductsNotFoundWarningQueryBuilderDsl>(p, AgentProductsNotFoundWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<AgentProductsNotFoundWarningQueryBuilderDsl, string> Products()
        {
            return new ComparableCollectionPredicateBuilder<AgentProductsNotFoundWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("products")),
            p => new CombinationQueryPredicate<AgentProductsNotFoundWarningQueryBuilderDsl>(p, AgentProductsNotFoundWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
