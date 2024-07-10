using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class SubRateQueryBuilderDsl
    {
        public SubRateQueryBuilderDsl()
        {
        }

        public static SubRateQueryBuilderDsl Of()
        {
            return new SubRateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SubRateQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<SubRateQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<SubRateQueryBuilderDsl>(p, SubRateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SubRateQueryBuilderDsl, decimal> Amount()
        {
            return new ComparisonPredicateBuilder<SubRateQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("amount")),
            p => new CombinationQueryPredicate<SubRateQueryBuilderDsl>(p, SubRateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
