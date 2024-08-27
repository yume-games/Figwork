using ImaginariumFramework.Runtime;

namespace ImaginariumFramework.Storage;

internal interface IGlobalStorage
{
    void Setup();

    void Register(Game game);
}