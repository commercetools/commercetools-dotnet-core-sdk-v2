// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductSelectionResourceIdentifierQueryBuilderDsl
    {
        public ProductSelectionResourceIdentifierQueryBuilderDsl()
        {
        }

        public static ProductSelectionResourceIdentifierQueryBuilderDsl Of()
        {
            return new ProductSelectionResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ProductSelectionResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ProductSelectionResourceIdentifierQueryBuilderDsl>(p, ProductSelectionResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSelectionResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductSelectionResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductSelectionResourceIdentifierQueryBuilderDsl>(p, ProductSelectionResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSelectionResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductSelectionResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductSelectionResourceIdentifierQueryBuilderDsl>(p, ProductSelectionResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
