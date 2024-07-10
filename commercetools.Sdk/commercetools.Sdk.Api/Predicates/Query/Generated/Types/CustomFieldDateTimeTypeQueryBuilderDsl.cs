using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldDateTimeTypeQueryBuilderDsl
    {
        public CustomFieldDateTimeTypeQueryBuilderDsl()
        {
        }

        public static CustomFieldDateTimeTypeQueryBuilderDsl Of()
        {
            return new CustomFieldDateTimeTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomFieldDateTimeTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomFieldDateTimeTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomFieldDateTimeTypeQueryBuilderDsl>(p, CustomFieldDateTimeTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
