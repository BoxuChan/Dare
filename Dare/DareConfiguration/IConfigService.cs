using Dare.DareConfiguration.Configurations;

namespace Dare.DareConfiguration;

public interface IConfigService<out T> : IDisposable where T : IDareConfiguration
{
    T Current { get; }
    string ConfigurationName { get; }
    string ConfigurationPath { get; }
    public event EventHandler? ConfigSave;
    void UpdateLastWriteTime();
}
