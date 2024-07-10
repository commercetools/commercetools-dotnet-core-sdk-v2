using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class CustomFieldSetTypeQueryBuilderDsl
    {
        public CustomFieldSetTypeQueryBuilderDsl()
        {
        }

        public static CustomFieldSetTypeQueryBuilderDsl Of()
        {
            return new CustomFieldSetTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomFieldSetTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomFieldSetTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomFieldSetTypeQueryBuilderDsl>(p, CustomFieldSetTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomFieldSetTypeQueryBuilderDsl> ElementType(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomFieldSetTypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("elementType"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldTypeQueryBuilderDsl.Of())),
                CustomFieldSetTypeQueryBuilderDsl.Of);
        }


    }
}
