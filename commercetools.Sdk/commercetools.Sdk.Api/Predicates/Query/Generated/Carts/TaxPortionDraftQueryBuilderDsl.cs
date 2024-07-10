using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class TaxPortionDraftQueryBuilderDsl
    {
        public TaxPortionDraftQueryBuilderDsl()
        {
        }

        public static TaxPortionDraftQueryBuilderDsl Of()
        {
            return new TaxPortionDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxPortionDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<TaxPortionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<TaxPortionDraftQueryBuilderDsl>(p, TaxPortionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxPortionDraftQueryBuilderDsl, decimal> Rate()
        {
            return new ComparisonPredicateBuilder<TaxPortionDraftQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("rate")),
            p => new CombinationQueryPredicate<TaxPortionDraftQueryBuilderDsl>(p, TaxPortionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TaxPortionDraftQueryBuilderDsl> Amount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxPortionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("amount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                TaxPortionDraftQueryBuilderDsl.Of);
        }


    }
}
