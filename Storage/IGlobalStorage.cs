using ImaginariumFramework.Runtime;

namespace ImaginariumFramework.Storage;

public interface IGlobalStorage
{
    void Setup(string storagePath);

    void Register(Game game);
}