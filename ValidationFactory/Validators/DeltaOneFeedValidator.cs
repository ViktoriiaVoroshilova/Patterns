using System.ComponentModel.DataAnnotations;
using ValidationFactory.Models;

namespace ValidationFactory.Validators
{
    internal class DeltaOneFeedValidator : FeedValidator<DeltaOneFeed>
    {
        public override ValidationResult Validate(DeltaOneFeed feed)
        {
            var result = base.Validate(feed);
            if (!string.IsNullOrEmpty(result.ErrorMessage)) return result;

            if (!IsValidIsin(feed.Isin))
                return new ValidationResult(ErrorCode.InvalidIsin);

            if (feed.MaturityDate <= feed.ValuationDate)
                return new ValidationResult(ErrorCode.InvalidMaturityDate);

            return new ValidationResult(string.Empty);
        }

        private bool IsValidIsin(string isin)
        {
            if (isin.Length != CorrectIsinSize) return false;

            for (var i = 0; i < isin.Length; i++)
            {
                if (i >= DigitSymbolsPosition && !char.IsDigit(isin[i]))
                    return false;

                if (i < DigitSymbolsPosition && !char.IsUpper(isin[i]))
                    return false;
            }

            return true;
        }

        private const int CorrectIsinSize = 10;
        private const int DigitSymbolsPosition = 2;
    }
}
