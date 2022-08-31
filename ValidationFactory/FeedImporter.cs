using ValidationFactory.Factories;
using ValidationFactory.Matchers;
using ValidationFactory.Models;
using ValidationFactory.Repository;
using ValidationFactory.Validators;

namespace ValidationFactory
{
    internal class FeedImporter<T> where T : TradeFeed
    {
        public FeedImporter(IContainerFactory<T> containerFactory)
        {
            _validator = containerFactory.CreateValidator();
            _matcher = containerFactory.CreateMatcher();
            _repository = containerFactory.CreateRepository();
        }

        public void Import(IEnumerable<T> feeds)
        {
            foreach (var feed in feeds)
            {
                var validationResult = _validator.Validate(feed);
                if (!string.IsNullOrEmpty(validationResult.ErrorMessage))
                {
                    _repository.SaveError(feed.StagingId, validationResult.ErrorMessage!);
                    return;
                }

                var existingFeeds = _repository.LoadFeeds();
                if (existingFeeds.Any(x => _matcher.Match(feed, x)))
                {
                    return;
                }

                _repository.SaveFeed(feed);
            }
        }

        private readonly FeedValidator<T> _validator;
        private readonly IFeedMatcher<T> _matcher;
        private readonly IDatabaseRepository<T> _repository;
    }
}
