using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class ApplicableRecurrencePoliciesQueryBuilderDsl
    {
        public ApplicableRecurrencePoliciesQueryBuilderDsl()
        {
        }

        public static ApplicableRecurrencePoliciesQueryBuilderDsl Of()
        {
            return new ApplicableRecurrencePoliciesQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApplicableRecurrencePoliciesQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApplicableRecurrencePoliciesQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApplicableRecurrencePoliciesQueryBuilderDsl>(p, ApplicableRecurrencePoliciesQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApplicableRecurrencePoliciesQueryBuilderDsl> RecurrencePolicies(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApplicableRecurrencePoliciesQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrencePolicies"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl.Of())),
                ApplicableRecurrencePoliciesQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApplicableRecurrencePoliciesQueryBuilderDsl> RecurrencePolicies()
        {
            return new CollectionPredicateBuilder<ApplicableRecurrencePoliciesQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("recurrencePolicies")),
                    p => new CombinationQueryPredicate<ApplicableRecurrencePoliciesQueryBuilderDsl>(p, ApplicableRecurrencePoliciesQueryBuilderDsl.Of));
        }

    }
}
