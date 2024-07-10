using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldLocalizedEnumValueQueryBuilderDsl
    {
        public CustomFieldLocalizedEnumValueQueryBuilderDsl()
        {
        }

        public static CustomFieldLocalizedEnumValueQueryBuilderDsl Of()
        {
            return new CustomFieldLocalizedEnumValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomFieldLocalizedEnumValueQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomFieldLocalizedEnumValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomFieldLocalizedEnumValueQueryBuilderDsl>(p, CustomFieldLocalizedEnumValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomFieldLocalizedEnumValueQueryBuilderDsl> Label(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomFieldLocalizedEnumValueQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("label"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CustomFieldLocalizedEnumValueQueryBuilderDsl.Of);
        }


    }
}
