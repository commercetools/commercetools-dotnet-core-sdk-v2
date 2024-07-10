using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomerGroups
{

    public partial class CustomerGroupUpdateActionQueryBuilderDsl
    {
        public CustomerGroupUpdateActionQueryBuilderDsl()
        {
        }

        public static CustomerGroupUpdateActionQueryBuilderDsl Of()
        {
            return new CustomerGroupUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerGroupUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerGroupUpdateActionQueryBuilderDsl>(p, CustomerGroupUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<CustomerGroupUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupChangeNameActionQueryBuilderDsl.Of()),
                CustomerGroupUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerGroupUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupSetCustomFieldActionQueryBuilderDsl.Of()),
                CustomerGroupUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerGroupUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupSetCustomTypeActionQueryBuilderDsl.Of()),
                CustomerGroupUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CustomerGroupUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupSetKeyActionQueryBuilderDsl.Of()),
                CustomerGroupUpdateActionQueryBuilderDsl.Of);
        }
    }
}
