using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerReferenceQueryBuilderDsl
    {
        public CustomerReferenceQueryBuilderDsl()
        {
        }

        public static CustomerReferenceQueryBuilderDsl Of()
        {
            return new CustomerReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<CustomerReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<CustomerReferenceQueryBuilderDsl>(p, CustomerReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerReferenceQueryBuilderDsl>(p, CustomerReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerQueryBuilderDsl.Of())),
                CustomerReferenceQueryBuilderDsl.Of);
        }


    }
}
