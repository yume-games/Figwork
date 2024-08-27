using ImaginariumFramework.Runtime;

namespace ImaginariumFramework.Storage;

internal abstract class GlobalStorage(string storagePath) : IGlobalStorage
{
    private readonly string _storagePath = storagePath;
    public string StoragePath { get => _storagePath; }

    public abstract void Setup();
    public abstract void Register(Game game);
}