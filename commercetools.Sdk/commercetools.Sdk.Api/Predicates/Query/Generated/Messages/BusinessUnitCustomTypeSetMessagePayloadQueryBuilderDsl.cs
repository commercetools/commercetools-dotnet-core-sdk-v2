using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl> CustomFields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customFields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl, string> OldTypeId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldTypeId")),
            p => new CombinationQueryPredicate<BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomTypeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
