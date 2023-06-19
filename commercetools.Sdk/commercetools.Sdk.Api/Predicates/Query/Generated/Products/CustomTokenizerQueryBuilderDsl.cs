// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class CustomTokenizerQueryBuilderDsl
    {
        public CustomTokenizerQueryBuilderDsl()
        {
        }

        public static CustomTokenizerQueryBuilderDsl Of()
        {
            return new CustomTokenizerQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomTokenizerQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomTokenizerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomTokenizerQueryBuilderDsl>(p, CustomTokenizerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<CustomTokenizerQueryBuilderDsl, string> Inputs()
        {
            return new ComparableCollectionPredicateBuilder<CustomTokenizerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inputs")),
            p => new CombinationQueryPredicate<CustomTokenizerQueryBuilderDsl>(p, CustomTokenizerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
