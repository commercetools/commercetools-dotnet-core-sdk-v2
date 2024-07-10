using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class ParcelMeasurementsQueryBuilderDsl
    {
        public ParcelMeasurementsQueryBuilderDsl()
        {
        }

        public static ParcelMeasurementsQueryBuilderDsl Of()
        {
            return new ParcelMeasurementsQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ParcelMeasurementsQueryBuilderDsl, long> HeightInMillimeter()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("heightInMillimeter")),
            p => new CombinationQueryPredicate<ParcelMeasurementsQueryBuilderDsl>(p, ParcelMeasurementsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelMeasurementsQueryBuilderDsl, long> LengthInMillimeter()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lengthInMillimeter")),
            p => new CombinationQueryPredicate<ParcelMeasurementsQueryBuilderDsl>(p, ParcelMeasurementsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelMeasurementsQueryBuilderDsl, long> WidthInMillimeter()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("widthInMillimeter")),
            p => new CombinationQueryPredicate<ParcelMeasurementsQueryBuilderDsl>(p, ParcelMeasurementsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelMeasurementsQueryBuilderDsl, long> WeightInGram()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("weightInGram")),
            p => new CombinationQueryPredicate<ParcelMeasurementsQueryBuilderDsl>(p, ParcelMeasurementsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
