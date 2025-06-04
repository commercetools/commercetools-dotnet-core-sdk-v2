using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl
    {
        public CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl()
        {
        }

        public static CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl Of()
        {
            return new CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl, string> ProjectKey()
        {
            return new ComparisonPredicateBuilder<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("projectKey")),
            p => new CombinationQueryPredicate<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl>(p, CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl> Cart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("cart"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl.Of())),
                CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl> Payments(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("payments"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl.Of())),
                CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl> Payments()
        {
            return new CollectionPredicateBuilder<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("payments")),
                    p => new CombinationQueryPredicate<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl>(p, CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl> Errors(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("errors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl.Of())),
                CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl> Errors()
        {
            return new CollectionPredicateBuilder<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("errors")),
                    p => new CombinationQueryPredicate<CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl>(p, CheckoutMessageOrderPayloadBaseDataQueryBuilderDsl.Of));
        }

    }
}
