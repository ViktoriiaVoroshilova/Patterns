namespace ValidationFactory.Validators
{
    internal class ErrorCode
    {
        public const string InvalidStagingId = "StagingId must be valid non-negative identifiers >= 1.";

        public const string InvalidCounterpartyId = "CounterpartyId must be valid non-negative identifiers >= 1.";

        public const string InvalidPrincipalId = "PrincipalId must be valid non-negative identifiers >= 1.";

        public const string InvalidSourceAccountId = "SourceAccountId must be valid non-negative identifiers >= 1.";

        public const string InvalidCurrentPrice = "CurrentPrice should be a valid price: >= 0 and have only 2 digits after delimiter.";

        public const string InvalidIsin = "Isin should be a valid ISIN. It should start with 2 capital letters and then 10 digits.";

        public const string InvalidMaturityDate = "MaturityDate should be bigger than ValuationDate.";

        public const string InvalidSedol = "Sedol should be a valid decimal bigger than 0 and less than 100.";

        public const string InvalidAssetValue = "AssetValue should be a valid decimal bigger than 0 and less than Sedol.";
    }
}