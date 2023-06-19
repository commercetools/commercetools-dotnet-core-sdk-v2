using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldsQueryBuilderDsl
    {
        public CustomFieldsQueryBuilderDsl()
        {
        }

        public static CustomFieldsQueryBuilderDsl Of()
        {
            return new CustomFieldsQueryBuilderDsl();
        }

        public CombinationQueryPredicate<CustomFieldsQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomFieldsQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeReferenceQueryBuilderDsl.Of())),
                CustomFieldsQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomFieldsQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomFieldsQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                CustomFieldsQueryBuilderDsl.Of);
        }


    }
}
