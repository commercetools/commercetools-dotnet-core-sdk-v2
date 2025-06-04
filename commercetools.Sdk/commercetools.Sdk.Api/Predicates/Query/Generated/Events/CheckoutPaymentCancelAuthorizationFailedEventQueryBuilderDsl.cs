using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl
    {
        public CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl()
        {
        }

        public static CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl Of()
        {
            return new CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl>(p, CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl>(p, CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl>(p, CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl>(p, CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl>(p, CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl> Data(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("data"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl.Of())),
                CheckoutPaymentCancelAuthorizationFailedEventQueryBuilderDsl.Of);
        }


    }
}
