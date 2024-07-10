using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StagedPriceDraftQueryBuilderDsl
    {
        public StagedPriceDraftQueryBuilderDsl()
        {
        }

        public static StagedPriceDraftQueryBuilderDsl Of()
        {
            return new StagedPriceDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<StagedPriceDraftQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedPriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyDraftQueryBuilderDsl.Of())),
                StagedPriceDraftQueryBuilderDsl.Of);
        }


    }
}
