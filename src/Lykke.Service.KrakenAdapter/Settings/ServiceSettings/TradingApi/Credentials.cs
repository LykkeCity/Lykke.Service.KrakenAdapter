using JetBrains.Annotations;

namespace Lykke.Service.KrakenAdapter.Settings.ServiceSettings.TradingApi
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public sealed class Credentials
    {
        public string InternalApiKey { get; set; }

        public string KrakenApiKey { get; set; }

        public string KrakenApiSecret { get; set; }
    }
}
