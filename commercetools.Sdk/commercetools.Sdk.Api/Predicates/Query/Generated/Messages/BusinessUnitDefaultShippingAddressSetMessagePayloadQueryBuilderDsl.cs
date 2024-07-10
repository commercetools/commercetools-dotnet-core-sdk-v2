using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitDefaultShippingAddressSetMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitDefaultShippingAddressSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitDefaultShippingAddressSetMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitDefaultShippingAddressSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitDefaultShippingAddressSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitDefaultShippingAddressSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitDefaultShippingAddressSetMessagePayloadQueryBuilderDsl>(p, BusinessUnitDefaultShippingAddressSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitDefaultShippingAddressSetMessagePayloadQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitDefaultShippingAddressSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                BusinessUnitDefaultShippingAddressSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
