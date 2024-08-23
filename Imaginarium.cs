using Imaginarium.Storage;
using Imaginarium.Storage.Local;

namespace Imaginarium;

public class Imaginarium<StorageType> where StorageType : IStorage, new()
{
    private string _mainFolderPath;
    private IStorage _storage;

    public Imaginarium(string mainFolderPath)
    {
        _mainFolderPath = mainFolderPath;
        _storage = new StorageType();
        _storage.Setup(mainFolderPath);
    }
}