// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class StackingQueryBuilderDsl
    {
        public StackingQueryBuilderDsl()
        {
        }

        public static StackingQueryBuilderDsl Of()
        {
            return new StackingQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StackingQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StackingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StackingQueryBuilderDsl>(p, StackingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
