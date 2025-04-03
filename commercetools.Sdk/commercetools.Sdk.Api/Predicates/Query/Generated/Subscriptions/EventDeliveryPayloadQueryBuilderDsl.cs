using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class EventDeliveryPayloadQueryBuilderDsl
    {
        public EventDeliveryPayloadQueryBuilderDsl()
        {
        }

        public static EventDeliveryPayloadQueryBuilderDsl Of()
        {
            return new EventDeliveryPayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<EventDeliveryPayloadQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<EventDeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<EventDeliveryPayloadQueryBuilderDsl>(p, EventDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EventDeliveryPayloadQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<EventDeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<EventDeliveryPayloadQueryBuilderDsl>(p, EventDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EventDeliveryPayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<EventDeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<EventDeliveryPayloadQueryBuilderDsl>(p, EventDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EventDeliveryPayloadQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<EventDeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<EventDeliveryPayloadQueryBuilderDsl>(p, EventDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EventDeliveryPayloadQueryBuilderDsl, string> Data()
        {
            return new ComparisonPredicateBuilder<EventDeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("data")),
            p => new CombinationQueryPredicate<EventDeliveryPayloadQueryBuilderDsl>(p, EventDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EventDeliveryPayloadQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<EventDeliveryPayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<EventDeliveryPayloadQueryBuilderDsl>(p, EventDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
