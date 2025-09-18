using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl
    {
        public PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl()
        {
        }

        public static PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl Of()
        {
            return new PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl>(p, PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl>(p, PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl>(p, PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl>(p, PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl>(p, PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl>(p, PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl>(p, PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, string> TransactionId()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transactionId")),
            p => new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl>(p, PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, string> NewInterfaceId()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newInterfaceId")),
            p => new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl>(p, PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, string> OldInterfaceId()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldInterfaceId")),
            p => new CombinationQueryPredicate<PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl>(p, PaymentTransactionInterfaceIdSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
