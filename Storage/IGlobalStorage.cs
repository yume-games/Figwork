using Figwork.Runtime;

namespace Figwork.Storage;

public interface IGlobalStorage
{
    void Setup(string storagePath);

    void Register(Game game);
    void Sync();
}