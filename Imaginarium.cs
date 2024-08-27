using ImaginariumFramework.Storage;
namespace ImaginariumFramework;

/// <summary>
/// Entry point for the Imaginarium framework
/// </summary>
public class Imaginarium
{
    private readonly IGlobalStorage _globalStorage;
    private readonly ILocalStorage _localStorage;

    /// <summary>
    /// Main constructor
    /// </summary>
    /// <param name="globalStorage">Global storage to be used</param>
    /// <param name="localStorage">Local storage to be used</param>
    public Imaginarium(IGlobalStorage globalStorage, ILocalStorage localStorage)
    {
        _globalStorage = globalStorage;
        _localStorage = localStorage;
    }

    /// <summary>
    /// Constructor that automatically sets global storage to SQLite
    /// </summary>
    /// <param name="localStorage">Local storage to be used</param>
    public Imaginarium(ILocalStorage localStorage) : this(new SQLiteStorage(), localStorage) {}
    
    /// <summary>
    /// Constructor that automatically sets both local and global storages to SQLite
    /// </summary>
    public Imaginarium() : this(new SQLiteStorage(), new SQLiteStorage()) {}

    
}