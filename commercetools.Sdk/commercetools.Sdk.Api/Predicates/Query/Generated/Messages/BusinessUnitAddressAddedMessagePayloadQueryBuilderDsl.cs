using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitAddressAddedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitAddressAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitAddressAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitAddressAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitAddressAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitAddressAddedMessagePayloadQueryBuilderDsl>(p, BusinessUnitAddressAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitAddressAddedMessagePayloadQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAddressAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                BusinessUnitAddressAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
