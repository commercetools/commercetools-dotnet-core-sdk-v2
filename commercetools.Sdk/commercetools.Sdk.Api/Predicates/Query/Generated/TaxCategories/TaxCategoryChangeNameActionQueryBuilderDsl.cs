using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxCategoryChangeNameActionQueryBuilderDsl
    {
        public TaxCategoryChangeNameActionQueryBuilderDsl()
        {
        }

        public static TaxCategoryChangeNameActionQueryBuilderDsl Of()
        {
            return new TaxCategoryChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxCategoryChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TaxCategoryChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TaxCategoryChangeNameActionQueryBuilderDsl>(p, TaxCategoryChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryChangeNameActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<TaxCategoryChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<TaxCategoryChangeNameActionQueryBuilderDsl>(p, TaxCategoryChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
