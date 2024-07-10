using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class CloudEventsPayloadQueryBuilderDsl
    {
        public CloudEventsPayloadQueryBuilderDsl()
        {
        }

        public static CloudEventsPayloadQueryBuilderDsl Of()
        {
            return new CloudEventsPayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string> Specversion()
        {
            return new ComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("specversion")),
            p => new CombinationQueryPredicate<CloudEventsPayloadQueryBuilderDsl>(p, CloudEventsPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CloudEventsPayloadQueryBuilderDsl>(p, CloudEventsPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CloudEventsPayloadQueryBuilderDsl>(p, CloudEventsPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string> Source()
        {
            return new ComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("source")),
            p => new CombinationQueryPredicate<CloudEventsPayloadQueryBuilderDsl>(p, CloudEventsPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string> Subject()
        {
            return new ComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("subject")),
            p => new CombinationQueryPredicate<CloudEventsPayloadQueryBuilderDsl>(p, CloudEventsPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, DateTime> Time()
        {
            return new ComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("time")),
            p => new CombinationQueryPredicate<CloudEventsPayloadQueryBuilderDsl>(p, CloudEventsPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string> Sequence()
        {
            return new ComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequence")),
            p => new CombinationQueryPredicate<CloudEventsPayloadQueryBuilderDsl>(p, CloudEventsPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string> Sequencetype()
        {
            return new ComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequencetype")),
            p => new CombinationQueryPredicate<CloudEventsPayloadQueryBuilderDsl>(p, CloudEventsPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string> Dataref()
        {
            return new ComparisonPredicateBuilder<CloudEventsPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("dataref")),
            p => new CombinationQueryPredicate<CloudEventsPayloadQueryBuilderDsl>(p, CloudEventsPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CloudEventsPayloadQueryBuilderDsl> Data(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.DeliveryPayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.DeliveryPayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CloudEventsPayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("data"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.DeliveryPayloadQueryBuilderDsl.Of())),
                CloudEventsPayloadQueryBuilderDsl.Of);
        }


    }
}
