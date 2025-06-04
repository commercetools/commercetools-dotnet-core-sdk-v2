using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class CheckoutPaymentRefundFailedEventQueryBuilderDsl
    {
        public CheckoutPaymentRefundFailedEventQueryBuilderDsl()
        {
        }

        public static CheckoutPaymentRefundFailedEventQueryBuilderDsl Of()
        {
            return new CheckoutPaymentRefundFailedEventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CheckoutPaymentRefundFailedEventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentRefundFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CheckoutPaymentRefundFailedEventQueryBuilderDsl>(p, CheckoutPaymentRefundFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentRefundFailedEventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentRefundFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<CheckoutPaymentRefundFailedEventQueryBuilderDsl>(p, CheckoutPaymentRefundFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentRefundFailedEventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentRefundFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<CheckoutPaymentRefundFailedEventQueryBuilderDsl>(p, CheckoutPaymentRefundFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentRefundFailedEventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentRefundFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CheckoutPaymentRefundFailedEventQueryBuilderDsl>(p, CheckoutPaymentRefundFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CheckoutPaymentRefundFailedEventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CheckoutPaymentRefundFailedEventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CheckoutPaymentRefundFailedEventQueryBuilderDsl>(p, CheckoutPaymentRefundFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CheckoutPaymentRefundFailedEventQueryBuilderDsl> Data(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CheckoutPaymentRefundFailedEventQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("data"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl.Of())),
                CheckoutPaymentRefundFailedEventQueryBuilderDsl.Of);
        }


    }
}
