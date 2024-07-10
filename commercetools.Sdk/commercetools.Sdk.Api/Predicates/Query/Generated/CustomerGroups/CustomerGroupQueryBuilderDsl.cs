using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomerGroups
{

    public partial class CustomerGroupQueryBuilderDsl
    {
        public CustomerGroupQueryBuilderDsl()
        {
        }

        public static CustomerGroupQueryBuilderDsl Of()
        {
            return new CustomerGroupQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerGroupQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerGroupQueryBuilderDsl>(p, CustomerGroupQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerGroupQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerGroupQueryBuilderDsl>(p, CustomerGroupQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CustomerGroupQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CustomerGroupQueryBuilderDsl>(p, CustomerGroupQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CustomerGroupQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CustomerGroupQueryBuilderDsl>(p, CustomerGroupQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerGroupQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CustomerGroupQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomerGroupQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CustomerGroupQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerGroupQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomerGroupQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomerGroupQueryBuilderDsl>(p, CustomerGroupQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomerGroupQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomerGroupQueryBuilderDsl>(p, CustomerGroupQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerGroupQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                CustomerGroupQueryBuilderDsl.Of);
        }


    }
}
