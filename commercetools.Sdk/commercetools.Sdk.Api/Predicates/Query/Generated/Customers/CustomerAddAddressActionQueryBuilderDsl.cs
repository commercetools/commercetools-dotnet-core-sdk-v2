using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerAddAddressActionQueryBuilderDsl
    {
        public CustomerAddAddressActionQueryBuilderDsl()
        {
        }

        public static CustomerAddAddressActionQueryBuilderDsl Of()
        {
            return new CustomerAddAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerAddAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerAddAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerAddAddressActionQueryBuilderDsl>(p, CustomerAddAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerAddAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                CustomerAddAddressActionQueryBuilderDsl.Of);
        }


    }
}
