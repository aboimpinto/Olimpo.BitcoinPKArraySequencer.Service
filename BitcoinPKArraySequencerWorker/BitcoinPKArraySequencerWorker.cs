using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BitcoinPKArraySequencerWorker
{
    public class BitcoinPKArraySequencerWorker : BackgroundService
    {
        private readonly ILogger<BitcoinPKArraySequencerWorker> _logger;

        public BitcoinPKArraySequencerWorker(ILogger<BitcoinPKArraySequencerWorker> logger)
        {
            this._logger = logger;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            this._logger.LogInformation("Start Sequencer");

            this._logger.LogInformation("End Sequencer");
            return Task.CompletedTask;
        }
    }
}
