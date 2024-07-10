using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerChangeAddressActionQueryBuilderDsl
    {
        public CustomerChangeAddressActionQueryBuilderDsl()
        {
        }

        public static CustomerChangeAddressActionQueryBuilderDsl Of()
        {
            return new CustomerChangeAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerChangeAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerChangeAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerChangeAddressActionQueryBuilderDsl>(p, CustomerChangeAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerChangeAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<CustomerChangeAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<CustomerChangeAddressActionQueryBuilderDsl>(p, CustomerChangeAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerChangeAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<CustomerChangeAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<CustomerChangeAddressActionQueryBuilderDsl>(p, CustomerChangeAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerChangeAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerChangeAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                CustomerChangeAddressActionQueryBuilderDsl.Of);
        }


    }
}
