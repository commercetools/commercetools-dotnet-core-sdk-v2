using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ExternalTaxAmountDraftQueryBuilderDsl
    {
        public ExternalTaxAmountDraftQueryBuilderDsl()
        {
        }

        public static ExternalTaxAmountDraftQueryBuilderDsl Of()
        {
            return new ExternalTaxAmountDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ExternalTaxAmountDraftQueryBuilderDsl> TotalGross(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExternalTaxAmountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalGross"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                ExternalTaxAmountDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ExternalTaxAmountDraftQueryBuilderDsl> TaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExternalTaxAmountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                ExternalTaxAmountDraftQueryBuilderDsl.Of);
        }


    }
}
