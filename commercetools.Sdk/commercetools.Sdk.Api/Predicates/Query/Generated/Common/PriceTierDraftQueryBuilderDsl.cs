using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class PriceTierDraftQueryBuilderDsl
    {
        public PriceTierDraftQueryBuilderDsl()
        {
        }

        public static PriceTierDraftQueryBuilderDsl Of()
        {
            return new PriceTierDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PriceTierDraftQueryBuilderDsl, long> MinimumQuantity()
        {
            return new ComparisonPredicateBuilder<PriceTierDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("minimumQuantity")),
            p => new CombinationQueryPredicate<PriceTierDraftQueryBuilderDsl>(p, PriceTierDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PriceTierDraftQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PriceTierDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                PriceTierDraftQueryBuilderDsl.Of);
        }


    }
}
