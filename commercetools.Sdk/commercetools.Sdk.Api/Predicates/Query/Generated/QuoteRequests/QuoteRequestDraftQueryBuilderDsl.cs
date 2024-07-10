using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.QuoteRequests
{

    public partial class QuoteRequestDraftQueryBuilderDsl
    {
        public QuoteRequestDraftQueryBuilderDsl()
        {
        }

        public static QuoteRequestDraftQueryBuilderDsl Of()
        {
            return new QuoteRequestDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<QuoteRequestDraftQueryBuilderDsl> Cart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("cart"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl.Of())),
                QuoteRequestDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteRequestDraftQueryBuilderDsl, long> CartVersion()
        {
            return new ComparisonPredicateBuilder<QuoteRequestDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartVersion")),
            p => new CombinationQueryPredicate<QuoteRequestDraftQueryBuilderDsl>(p, QuoteRequestDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<QuoteRequestDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<QuoteRequestDraftQueryBuilderDsl>(p, QuoteRequestDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestDraftQueryBuilderDsl, string> Comment()
        {
            return new ComparisonPredicateBuilder<QuoteRequestDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("comment")),
            p => new CombinationQueryPredicate<QuoteRequestDraftQueryBuilderDsl>(p, QuoteRequestDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRequestDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                QuoteRequestDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteRequestDraftQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                QuoteRequestDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteRequestDraftQueryBuilderDsl, string> PurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<QuoteRequestDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("purchaseOrderNumber")),
            p => new CombinationQueryPredicate<QuoteRequestDraftQueryBuilderDsl>(p, QuoteRequestDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
