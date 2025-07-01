using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl
    {
        public PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl()
        {
        }

        public static PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl Of()
        {
            return new PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl>(p, PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl>(p, PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl>(p, PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl>(p, PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl>(p, PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl>(p, PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl>(p, PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl>(p, PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, string> OldStatus()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldStatus")),
            p => new CombinationQueryPredicate<PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl>(p, PaymentMethodPaymentMethodStatusSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
