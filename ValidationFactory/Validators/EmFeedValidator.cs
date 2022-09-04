using System.ComponentModel.DataAnnotations;
using ValidationFactory.Models;

namespace ValidationFactory.Validators
{
    internal class EmFeedValidator : FeedValidator<EmFeed>
    {
        public override ValidationResult Validate(EmFeed feed)
        {
            var result = base.Validate(feed);
            if (!string.IsNullOrEmpty(result.ErrorMessage)) return result;

            if (feed.Sedol < MinSedolNumber || feed.Sedol > MaxSedolNumber)
                return new ValidationResult(ErrorCode.InvalidSedol);

            if (feed.AssetValue < MinAssetValueNumber || feed.AssetValue >= feed.Sedol)
                return new ValidationResult(ErrorCode.InvalidAssetValue);

            return new ValidationResult(string.Empty);
        }

        private const int MinSedolNumber = 1;
        private const int MaxSedolNumber = 99;
        private const int MinAssetValueNumber = 1;
    }
}