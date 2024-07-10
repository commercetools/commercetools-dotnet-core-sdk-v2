using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderEditAppliedMessageQueryBuilderDsl
    {
        public OrderEditAppliedMessageQueryBuilderDsl()
        {
        }

        public static OrderEditAppliedMessageQueryBuilderDsl Of()
        {
            return new OrderEditAppliedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditAppliedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderEditAppliedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl>(p, OrderEditAppliedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditAppliedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderEditAppliedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl>(p, OrderEditAppliedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditAppliedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderEditAppliedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl>(p, OrderEditAppliedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditAppliedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderEditAppliedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl>(p, OrderEditAppliedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderEditAppliedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderEditAppliedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderEditAppliedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderEditAppliedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl>(p, OrderEditAppliedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderEditAppliedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderEditAppliedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderEditAppliedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl>(p, OrderEditAppliedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditAppliedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderEditAppliedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl>(p, OrderEditAppliedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderEditAppliedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl> Edit(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("edit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl.Of())),
                OrderEditAppliedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl> Result(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditAppliedQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditAppliedQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditAppliedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("result"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditAppliedQueryBuilderDsl.Of())),
                OrderEditAppliedMessageQueryBuilderDsl.Of);
        }


    }
}
