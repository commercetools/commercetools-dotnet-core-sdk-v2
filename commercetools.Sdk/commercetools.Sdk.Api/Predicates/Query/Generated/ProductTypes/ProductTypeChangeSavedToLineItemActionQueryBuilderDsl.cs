// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeChangeSavedToLineItemActionQueryBuilderDsl
    {
        public ProductTypeChangeSavedToLineItemActionQueryBuilderDsl()
        {
        }

        public static ProductTypeChangeSavedToLineItemActionQueryBuilderDsl Of()
        {
            return new ProductTypeChangeSavedToLineItemActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeChangeSavedToLineItemActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeSavedToLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeChangeSavedToLineItemActionQueryBuilderDsl>(p, ProductTypeChangeSavedToLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeSavedToLineItemActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeSavedToLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeChangeSavedToLineItemActionQueryBuilderDsl>(p, ProductTypeChangeSavedToLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeSavedToLineItemActionQueryBuilderDsl, bool> SavedToLineItem()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeSavedToLineItemActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("savedToLineItem")),
            p => new CombinationQueryPredicate<ProductTypeChangeSavedToLineItemActionQueryBuilderDsl>(p, ProductTypeChangeSavedToLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
