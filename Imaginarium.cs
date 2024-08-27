using ImaginariumFramework.Storage;
namespace ImaginariumFramework;

public class Imaginarium(IGlobalStorage globalStorage, ILocalStorage localStorage)
{
    private readonly IGlobalStorage _globalStorage = globalStorage;
    private readonly ILocalStorage _localStorage = localStorage;

    public Imaginarium(ILocalStorage localStorage) : this(new SQLiteStorage(), localStorage) {}
    public Imaginarium() : this(new SQLiteStorage(), new SQLiteStorage()) {}

    
}