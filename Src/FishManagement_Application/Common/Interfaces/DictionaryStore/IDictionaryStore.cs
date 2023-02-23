namespace FishManagement_Application.Common.Interfaces.DictionaryStore;

public interface IDictionaryStore<TKey, TValue>
{
    void AddNewDictionary(TKey key, TValue value);
    void DeleteDictionary(TKey key);
    TValue GetDitionayValueByKey(TKey key);
    TValue GetDitionayKeyByValue(TValue value);
    KeyValuePair<TKey, TValue> GetDictionaryByKey(TKey key);
    void UpdateDictionaryValueByKey(TKey key, TValue value);
    Dictionary<TKey, TValue> GetAllDictionaryData();
}
