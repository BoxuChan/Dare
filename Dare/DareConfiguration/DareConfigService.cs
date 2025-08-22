using Dare.DareConfiguration.Configurations;

namespace Dare.DareConfiguration;

public class DareConfigService : ConfigurationServiceBase<DareConfig>
{
    public const string ConfigName = "config.json";

    public DareConfigService(string configDir) : base(configDir)
    {
    }

    public override string ConfigurationName => ConfigName;
}