// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxCategoryResourceIdentifierQueryBuilderDsl
    {
        public TaxCategoryResourceIdentifierQueryBuilderDsl()
        {
        }

        public static TaxCategoryResourceIdentifierQueryBuilderDsl Of()
        {
            return new TaxCategoryResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxCategoryResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<TaxCategoryResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<TaxCategoryResourceIdentifierQueryBuilderDsl>(p, TaxCategoryResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<TaxCategoryResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<TaxCategoryResourceIdentifierQueryBuilderDsl>(p, TaxCategoryResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<TaxCategoryResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<TaxCategoryResourceIdentifierQueryBuilderDsl>(p, TaxCategoryResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
