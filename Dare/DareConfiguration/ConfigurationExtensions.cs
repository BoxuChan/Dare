using Dare.DareConfiguration.Configurations;

namespace Dare.DareConfiguration;

public static class ConfigurationExtensions
{
    public static bool HasValidSetup(this DareConfig configuration)
    {
        return configuration.AcceptedAgreement && configuration.InitialScanComplete
                    && !string.IsNullOrEmpty(configuration.CacheFolder)
                    && Directory.Exists(configuration.CacheFolder);
    }
}