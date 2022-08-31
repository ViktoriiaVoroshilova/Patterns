using ValidationFactory.Matchers;
using ValidationFactory.Models;
using ValidationFactory.Repository;
using ValidationFactory.Validators;

namespace ValidationFactory.Factories
{
    internal class EmFeedFactory : IContainerFactory<EmFeed>
    {
        public IFeedMatcher<EmFeed> CreateMatcher()
        {
            return new EmFeedMatcher();
        }

        public IDatabaseRepository<EmFeed> CreateRepository()
        {
            return new DatabaseRepository<EmFeed>();
        }

        public FeedValidator<EmFeed> CreateValidator()
        {
            return new EmFeedValidator();
        }
    }
}
