using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomerGroups
{

    public partial class CustomerGroupDraftQueryBuilderDsl
    {
        public CustomerGroupDraftQueryBuilderDsl()
        {
        }

        public static CustomerGroupDraftQueryBuilderDsl Of()
        {
            return new CustomerGroupDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomerGroupDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomerGroupDraftQueryBuilderDsl>(p, CustomerGroupDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupDraftQueryBuilderDsl, string> GroupName()
        {
            return new ComparisonPredicateBuilder<CustomerGroupDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("groupName")),
            p => new CombinationQueryPredicate<CustomerGroupDraftQueryBuilderDsl>(p, CustomerGroupDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerGroupDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                CustomerGroupDraftQueryBuilderDsl.Of);
        }


    }
}
