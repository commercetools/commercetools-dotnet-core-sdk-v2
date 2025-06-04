using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class CheckoutPaymentRefundedEventQueryBuilderDsl
    {
        public CheckoutPaymentRefundedEventQueryBuilderDsl()
        {
        }

        public static CheckoutPaymentRefundedEventQueryBuilderDsl Of()
        {
            return new CheckoutPaymentRefundedEventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CheckoutPaymentRefundedEventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentRefundedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CheckoutPaymentRefundedEventQueryBuilderDsl>(p, CheckoutPaymentRefundedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentRefundedEventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentRefundedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<CheckoutPaymentRefundedEventQueryBuilderDsl>(p, CheckoutPaymentRefundedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentRefundedEventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentRefundedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<CheckoutPaymentRefundedEventQueryBuilderDsl>(p, CheckoutPaymentRefundedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentRefundedEventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentRefundedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CheckoutPaymentRefundedEventQueryBuilderDsl>(p, CheckoutPaymentRefundedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentRefundedEventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentRefundedEventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CheckoutPaymentRefundedEventQueryBuilderDsl>(p, CheckoutPaymentRefundedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CheckoutPaymentRefundedEventQueryBuilderDsl> Data(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CheckoutPaymentRefundedEventQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("data"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl.Of())),
                CheckoutPaymentRefundedEventQueryBuilderDsl.Of);
        }


    }
}
