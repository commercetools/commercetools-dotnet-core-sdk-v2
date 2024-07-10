using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitDefaultBillingAddressSetMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitDefaultBillingAddressSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitDefaultBillingAddressSetMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitDefaultBillingAddressSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitDefaultBillingAddressSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitDefaultBillingAddressSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitDefaultBillingAddressSetMessagePayloadQueryBuilderDsl>(p, BusinessUnitDefaultBillingAddressSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitDefaultBillingAddressSetMessagePayloadQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitDefaultBillingAddressSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                BusinessUnitDefaultBillingAddressSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
