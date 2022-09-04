using ValidationFactory.Matchers;
using ValidationFactory.Models;
using ValidationFactory.Repository;
using ValidationFactory.Validators;

namespace ValidationFactory.Factories
{
    internal interface IContainerFactory<T> where T: TradeFeed
    {
        FeedValidator<T> CreateValidator();

        IFeedMatcher<T> CreateMatcher();

        IDatabaseRepository<T> CreateRepository();
    }
}
