using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl
    {
        public CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl()
        {
        }

        public static CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl Of()
        {
            return new CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl>(p, CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl>(p, CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl>(p, CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl>(p, CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl>(p, CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl> Data(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("data"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl.Of())),
                CheckoutPaymentAuthorizationCancelledEventQueryBuilderDsl.Of);
        }


    }
}
