using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitChangeNameActionQueryBuilderDsl
    {
        public BusinessUnitChangeNameActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitChangeNameActionQueryBuilderDsl Of()
        {
            return new BusinessUnitChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitChangeNameActionQueryBuilderDsl>(p, BusinessUnitChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitChangeNameActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<BusinessUnitChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<BusinessUnitChangeNameActionQueryBuilderDsl>(p, BusinessUnitChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
