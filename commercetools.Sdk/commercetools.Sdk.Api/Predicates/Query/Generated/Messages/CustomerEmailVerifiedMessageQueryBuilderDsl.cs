using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerEmailVerifiedMessageQueryBuilderDsl
    {
        public CustomerEmailVerifiedMessageQueryBuilderDsl()
        {
        }

        public static CustomerEmailVerifiedMessageQueryBuilderDsl Of()
        {
            return new CustomerEmailVerifiedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerEmailVerifiedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerEmailVerifiedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl>(p, CustomerEmailVerifiedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerEmailVerifiedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerEmailVerifiedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl>(p, CustomerEmailVerifiedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerEmailVerifiedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CustomerEmailVerifiedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl>(p, CustomerEmailVerifiedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerEmailVerifiedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CustomerEmailVerifiedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl>(p, CustomerEmailVerifiedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CustomerEmailVerifiedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CustomerEmailVerifiedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerEmailVerifiedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<CustomerEmailVerifiedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl>(p, CustomerEmailVerifiedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                CustomerEmailVerifiedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerEmailVerifiedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<CustomerEmailVerifiedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl>(p, CustomerEmailVerifiedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerEmailVerifiedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerEmailVerifiedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl>(p, CustomerEmailVerifiedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerEmailVerifiedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                CustomerEmailVerifiedMessageQueryBuilderDsl.Of);
        }


    }
}
