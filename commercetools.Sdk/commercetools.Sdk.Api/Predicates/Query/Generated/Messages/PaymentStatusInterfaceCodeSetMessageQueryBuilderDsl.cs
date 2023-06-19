using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl
    {
        public PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl()
        {
        }

        public static PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl Of()
        {
            return new PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl>(p, PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl>(p, PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl>(p, PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl>(p, PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl>(p, PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl>(p, PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl>(p, PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, string> PaymentId()
        {
            return new ComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentId")),
            p => new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl>(p, PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, string> InterfaceCode()
        {
            return new ComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceCode")),
            p => new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl>(p, PaymentStatusInterfaceCodeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
