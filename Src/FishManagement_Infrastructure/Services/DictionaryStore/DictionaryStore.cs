namespace FishManagement_Infrastructure.Services.DictionaryStore;
public class DictionaryStore<TKey, TValue> : IDictionaryStore<TKey, TValue>
{
    private readonly Dictionary<TKey, TValue> _dictionary;
    public DictionaryStore()
    {
        _dictionary = new Dictionary<TKey, TValue>();
    }

    public void AddNewDictionary(TKey key, TValue value)
    => _dictionary.Add(key, value);

    public void DeleteDictionary(TKey key)
    => _dictionary.Remove(key);

    public Dictionary<TKey, TValue> GetAllDictionaryData()
    {
        var finalDictionary = new Dictionary<TKey, TValue>();
        foreach (KeyValuePair<TKey, TValue> data in _dictionary.ToList())
        {
            finalDictionary.Add(data.Key, data.Value);
        }
        return finalDictionary;
    }
    public KeyValuePair<TKey, TValue> GetDictionaryByKey(TKey key)
    => _dictionary.FirstOrDefault(a => a.Key.Equals(key));

    public TValue GetDitionayKeyByValue(TValue value)
    => _dictionary.FirstOrDefault(a => a.Value.Equals(value)).Value;

    public TValue GetDitionayValueByKey(TKey key)
    => _dictionary[key];

    public void UpdateDictionaryValueByKey(TKey key, TValue value)
    => _dictionary[key] = value;
}
