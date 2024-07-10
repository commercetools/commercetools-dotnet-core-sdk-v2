using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class TaxPortionQueryBuilderDsl
    {
        public TaxPortionQueryBuilderDsl()
        {
        }

        public static TaxPortionQueryBuilderDsl Of()
        {
            return new TaxPortionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxPortionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<TaxPortionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<TaxPortionQueryBuilderDsl>(p, TaxPortionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxPortionQueryBuilderDsl, decimal> Rate()
        {
            return new ComparisonPredicateBuilder<TaxPortionQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("rate")),
            p => new CombinationQueryPredicate<TaxPortionQueryBuilderDsl>(p, TaxPortionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TaxPortionQueryBuilderDsl> Amount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxPortionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("amount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                TaxPortionQueryBuilderDsl.Of);
        }


    }
}
