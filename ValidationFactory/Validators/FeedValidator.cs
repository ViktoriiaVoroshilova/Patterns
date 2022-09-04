using ValidationFactory.Models;
using System.ComponentModel.DataAnnotations;

namespace ValidationFactory.Validators
{
    public abstract class FeedValidator<T> where T : TradeFeed
    {
        virtual public ValidationResult Validate(T feed)
        {
            if (feed.StagingId < 1)
                return new ValidationResult(ErrorCode.InvalidStagingId);

            if (feed.CounterpartyId < 1)
                return new ValidationResult(ErrorCode.InvalidCounterpartyId);

            if (feed.PrincipalId < 1)
                return new ValidationResult(ErrorCode.InvalidPrincipalId);

            if (feed.SourceAccountId < 1)
                return new ValidationResult(ErrorCode.InvalidSourceAccountId);

            if (IsCurrentPriceValid(feed.CurrentPrice))
                return new ValidationResult(ErrorCode.InvalidCurrentPrice);

            return new ValidationResult(string.Empty);
        }

        private bool IsCurrentPriceValid(decimal price)
        {
            if (price < 0) return false;

            return decimal.Remainder(price, (int)price) <= LastTwoDigitNumber;
        }

        private const int LastTwoDigitNumber = 99;
    }
}