// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class InsufficientScopeErrorQueryBuilderDsl
    {
        public InsufficientScopeErrorQueryBuilderDsl()
        {
        }

        public static InsufficientScopeErrorQueryBuilderDsl Of()
        {
            return new InsufficientScopeErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InsufficientScopeErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<InsufficientScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<InsufficientScopeErrorQueryBuilderDsl>(p, InsufficientScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InsufficientScopeErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<InsufficientScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<InsufficientScopeErrorQueryBuilderDsl>(p, InsufficientScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
