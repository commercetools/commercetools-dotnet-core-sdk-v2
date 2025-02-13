using System;
using commercetools.Base.Models;
using commercetools.Sdk.Api.Predicates.Query.Common;

namespace commercetools.Sdk.Api.Predicates.Query.Types
{
    public class FieldContainerValueQueryBuilderDsl
    {

        private readonly string _fieldName;

        public FieldContainerValueQueryBuilderDsl(string fieldName)
        {
            this._fieldName = fieldName;
        }

        public CombinationQueryPredicate<FieldContainerQueryBuilderDsl> PlainEnum(
                Func<CustomFieldEnumValueQueryBuilderDsl, CombinationQueryPredicate<CustomFieldEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldContainerQueryBuilderDsl>(ContainerQueryPredicate.Of()
                    .Parent(new ConstantQueryPredicate(_fieldName))
                    .Inner(fn.Invoke(CustomFieldEnumValueQueryBuilderDsl.Of())),
                FieldContainerQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<FieldContainerQueryBuilderDsl> LocalizedEnum(
                Func<CustomFieldLocalizedEnumValueQueryBuilderDsl, CombinationQueryPredicate<CustomFieldLocalizedEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldContainerQueryBuilderDsl>(
                ContainerQueryPredicate.Of()
                    .Parent(new ConstantQueryPredicate(_fieldName))
                    .Inner(fn.Invoke(CustomFieldLocalizedEnumValueQueryBuilderDsl.Of())),
                FieldContainerQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<FieldContainerQueryBuilderDsl> Money(
                Func<MoneyQueryBuilderDsl, CombinationQueryPredicate<MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldContainerQueryBuilderDsl>(ContainerQueryPredicate.Of()
                    .Parent(new ConstantQueryPredicate(_fieldName))
                    .Inner(fn.Invoke(MoneyQueryBuilderDsl.Of())),
                FieldContainerQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<FieldContainerQueryBuilderDsl> Reference(
                Func<ReferenceQueryBuilderDsl, CombinationQueryPredicate<ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldContainerQueryBuilderDsl>(ContainerQueryPredicate.Of()
                    .Parent(new ConstantQueryPredicate(_fieldName))
                    .Inner(fn.Invoke(ReferenceQueryBuilderDsl.Of())),
                FieldContainerQueryBuilderDsl.Of);
        }

        public ComparisonPredicateBuilder<FieldContainerQueryBuilderDsl, long> LongNumber()
        {
            return new ComparisonPredicateBuilder<FieldContainerQueryBuilderDsl, long>(
                BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate(_fieldName)),
                p => new CombinationQueryPredicate<FieldContainerQueryBuilderDsl>(p, FieldContainerQueryBuilderDsl.Of),
                PredicateFormatter.Format);
        }

        public IComparisonPredicateBuilder<FieldContainerQueryBuilderDsl, decimal> DoubleNumber()
        {
            return new ComparisonPredicateBuilder<FieldContainerQueryBuilderDsl, decimal>(
                BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate(_fieldName)),
                p => new CombinationQueryPredicate<FieldContainerQueryBuilderDsl>(p, FieldContainerQueryBuilderDsl.Of), PredicateFormatter.Format);
        }

        public IComparisonPredicateBuilder<FieldContainerQueryBuilderDsl, string> String()
        {
            return new ComparisonPredicateBuilder<FieldContainerQueryBuilderDsl, string>(
                BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate(_fieldName)),
                p => new CombinationQueryPredicate<FieldContainerQueryBuilderDsl>(p, FieldContainerQueryBuilderDsl.Of), PredicateFormatter.Format);
        }

        public IComparisonPredicateBuilder<FieldContainerQueryBuilderDsl, Date> Date()
        {
            return new DateComparisonPredicateBuilder<FieldContainerQueryBuilderDsl>(
                BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate(_fieldName)),
                p => new CombinationQueryPredicate<FieldContainerQueryBuilderDsl>(p, FieldContainerQueryBuilderDsl.Of));
        }

        public IComparisonPredicateBuilder<FieldContainerQueryBuilderDsl, DateTime> DateTime()
        {
            return new DateTimeComparisonPredicateBuilder<FieldContainerQueryBuilderDsl>(
                BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate(_fieldName)),
                p => new CombinationQueryPredicate<FieldContainerQueryBuilderDsl>(p, FieldContainerQueryBuilderDsl.Of));
        }

        public IComparisonPredicateBuilder<FieldContainerQueryBuilderDsl, TimeSpan> Time()
        {
            return new TimeComparisonPredicateBuilder<FieldContainerQueryBuilderDsl>(
                BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate(_fieldName)),
                p => new CombinationQueryPredicate<FieldContainerQueryBuilderDsl>(p, FieldContainerQueryBuilderDsl.Of));
        }
    }
}

