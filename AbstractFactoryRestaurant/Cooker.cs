using Microsoft.Extensions.Logging;

namespace AbstractFactoryRestaurant
{
    internal class Cooker : ICooker
    {
        public Cooker(ILogger<Cooker> logger)
        {
            _logger = logger;
        }

        public void FryChicken(int amount, Level level)
        {
            _logger.LogInformation($"{amount} grams of chicken, which were {level} fried.\n");
        }

        public void FryRice(int amount, Level level)
        {
            _logger.LogInformation($"{amount} grams of rice, which were {level} fried.\n");
        }

        public void PepperChicken(Level level)
        {
            _logger.LogInformation($"Chicken was {level} peppered.\n");
        }

        public void PepperRice(Level level)
        {
            _logger.LogInformation($"Rice was {level} peppered.\n");
        }

        public void SaltChicken(Level level)
        {
            _logger.LogInformation($"Chicken was {level} salted.\n");
        }

        public void SaltRice(Level level)
        {
            _logger.LogInformation($"Rice was {level} salted.\n");
        }

        private readonly ILogger<Cooker> _logger;
    }
}
