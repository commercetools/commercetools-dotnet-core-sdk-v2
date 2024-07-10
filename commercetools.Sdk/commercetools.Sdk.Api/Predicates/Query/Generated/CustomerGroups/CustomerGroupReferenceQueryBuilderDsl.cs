using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomerGroups
{

    public partial class CustomerGroupReferenceQueryBuilderDsl
    {
        public CustomerGroupReferenceQueryBuilderDsl()
        {
        }

        public static CustomerGroupReferenceQueryBuilderDsl Of()
        {
            return new CustomerGroupReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<CustomerGroupReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<CustomerGroupReferenceQueryBuilderDsl>(p, CustomerGroupReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerGroupReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerGroupReferenceQueryBuilderDsl>(p, CustomerGroupReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerGroupReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupQueryBuilderDsl.Of())),
                CustomerGroupReferenceQueryBuilderDsl.Of);
        }


    }
}
