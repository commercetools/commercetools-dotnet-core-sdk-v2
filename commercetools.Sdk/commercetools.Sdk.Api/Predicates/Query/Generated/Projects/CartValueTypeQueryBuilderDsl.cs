// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class CartValueTypeQueryBuilderDsl
    {
        public CartValueTypeQueryBuilderDsl()
        {
        }

        public static CartValueTypeQueryBuilderDsl Of()
        {
            return new CartValueTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartValueTypeQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartValueTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartValueTypeQueryBuilderDsl>(p, CartValueTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
