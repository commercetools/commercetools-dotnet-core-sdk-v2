using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldEnumTypeQueryBuilderDsl
    {
        public CustomFieldEnumTypeQueryBuilderDsl()
        {
        }

        public static CustomFieldEnumTypeQueryBuilderDsl Of()
        {
            return new CustomFieldEnumTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomFieldEnumTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomFieldEnumTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomFieldEnumTypeQueryBuilderDsl>(p, CustomFieldEnumTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomFieldEnumTypeQueryBuilderDsl> Values(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomFieldEnumTypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("values"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldEnumValueQueryBuilderDsl.Of())),
                CustomFieldEnumTypeQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomFieldEnumTypeQueryBuilderDsl> Values()
        {
            return new CollectionPredicateBuilder<CustomFieldEnumTypeQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("values")),
                    p => new CombinationQueryPredicate<CustomFieldEnumTypeQueryBuilderDsl>(p, CustomFieldEnumTypeQueryBuilderDsl.Of));
        }

    }
}
