using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitChangeAddressActionQueryBuilderDsl
    {
        public BusinessUnitChangeAddressActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitChangeAddressActionQueryBuilderDsl Of()
        {
            return new BusinessUnitChangeAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitChangeAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitChangeAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitChangeAddressActionQueryBuilderDsl>(p, BusinessUnitChangeAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitChangeAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitChangeAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<BusinessUnitChangeAddressActionQueryBuilderDsl>(p, BusinessUnitChangeAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitChangeAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<BusinessUnitChangeAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<BusinessUnitChangeAddressActionQueryBuilderDsl>(p, BusinessUnitChangeAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitChangeAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitChangeAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                BusinessUnitChangeAddressActionQueryBuilderDsl.Of);
        }


    }
}
