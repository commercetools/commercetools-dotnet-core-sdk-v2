using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldLocalizedEnumTypeQueryBuilderDsl
    {
        public CustomFieldLocalizedEnumTypeQueryBuilderDsl()
        {
        }

        public static CustomFieldLocalizedEnumTypeQueryBuilderDsl Of()
        {
            return new CustomFieldLocalizedEnumTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomFieldLocalizedEnumTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomFieldLocalizedEnumTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomFieldLocalizedEnumTypeQueryBuilderDsl>(p, CustomFieldLocalizedEnumTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomFieldLocalizedEnumTypeQueryBuilderDsl> Values(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomFieldLocalizedEnumTypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("values"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumValueQueryBuilderDsl.Of())),
                CustomFieldLocalizedEnumTypeQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomFieldLocalizedEnumTypeQueryBuilderDsl> Values()
        {
            return new CollectionPredicateBuilder<CustomFieldLocalizedEnumTypeQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("values")),
                    p => new CombinationQueryPredicate<CustomFieldLocalizedEnumTypeQueryBuilderDsl>(p, CustomFieldLocalizedEnumTypeQueryBuilderDsl.Of));
        }

    }
}
