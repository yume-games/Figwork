using Figwork.Runtime;

namespace Figwork.Storage;

public class SQLiteStorage : IGlobalStorage, ILocalStorage
{
    public void Setup(string storagePath)
    {
        throw new NotImplementedException();
    }

    public void Register(Game game)
    {
        throw new NotImplementedException();
    }

    public void Sync()
    {
        throw new NotImplementedException();
    }
}