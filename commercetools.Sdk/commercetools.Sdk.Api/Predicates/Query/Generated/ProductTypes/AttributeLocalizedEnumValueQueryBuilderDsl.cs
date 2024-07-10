using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeLocalizedEnumValueQueryBuilderDsl
    {
        public AttributeLocalizedEnumValueQueryBuilderDsl()
        {
        }

        public static AttributeLocalizedEnumValueQueryBuilderDsl Of()
        {
            return new AttributeLocalizedEnumValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeLocalizedEnumValueQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AttributeLocalizedEnumValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AttributeLocalizedEnumValueQueryBuilderDsl>(p, AttributeLocalizedEnumValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeLocalizedEnumValueQueryBuilderDsl> Label(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeLocalizedEnumValueQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("label"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AttributeLocalizedEnumValueQueryBuilderDsl.Of);
        }


    }
}
