namespace FishManagement_Infrastructure_Tests.Services_Tests.Ditctionary;
[TestFixture]
public class DictionaryStore_Tests
{
    string key = "FirstKey";
    int value = 2;
    private readonly IDictionaryStore<string, int> _dictionaryStore;
    public DictionaryStore_Tests()
    {
        _dictionaryStore = new DictionaryStore<string, int>();
    }
    [Test]
    public void AddNewDictonary_AddNewDictionaryWithKeyAndValueAndChecksKeyFromDictionary_TheKeyHaveToStoreInDictionary()
    {
        //Arrage

        //Act
        _dictionaryStore.AddNewDictionary(key, value);
        var keyValuePair = _dictionaryStore.GetDictionaryByKey(key);
        //Assert
        Assert.AreEqual(key, keyValuePair.Key);
    }
    [Test]
    public void DeleteDictionary_AddNewDictionaryRecordAndDeleteItAndGetDataFromDictionaryMustBeNull_DicionaryMustBeNull()
    {

        //Arrage

        //Act
        _dictionaryStore.AddNewDictionary(key, value);
        _dictionaryStore.DeleteDictionary(key);
        var keyValuePair = _dictionaryStore.GetDictionaryByKey(key);
        //Assert
        Assert.IsNull(keyValuePair.Key);
    }
    [Test]
    public void GetDitionayValueByKey_AddNewDictionaryAndGetValueFromIt_TheValueMustBeInsertedValue()
    {
        //Arrage

        //Act
        _dictionaryStore.AddNewDictionary(key, value);
        var keyValuePair = _dictionaryStore.GetDictionaryByKey(key);
        //Assert
        Assert.AreEqual(value, keyValuePair.Value);
    }
    [Test]
    public void GetDitionayKeyByValue_AddDictionaryAndGetDictionaryKeyByValue_TheInsertedKeyMustBeEqulaToKey()
    {
        //Arrage

        //Act
        _dictionaryStore.AddNewDictionary(key, value);
        var keyValuePair = _dictionaryStore.GetDictionaryByKey(key);
        //Assert
        Assert.AreEqual(key, keyValuePair.Key);
    }
    [Test]
    public void GetDictionaryByKey_AddNewDictionary_InsertedValueAndKeyMustBeEqualToKeyAndValueInMemory()
    {
        //Arrage

        //Act
        _dictionaryStore.AddNewDictionary(key, value);
        var keyValuePair = _dictionaryStore.GetDictionaryByKey(key);
        //Assert
        Assert.AreEqual(key, keyValuePair.Key);
        Assert.AreEqual(value, keyValuePair.Value);
    }
    [Test]
    public void UpdateDictionaryValueByKey_InsertNewDictionaryAndUpdateItValue_TheDictionaryValueHaveToEqualInsertedValue()
    {
        //Arrage
        int secondValue = 3;
        //Act
        _dictionaryStore.AddNewDictionary(key, value);
        _dictionaryStore.UpdateDictionaryValueByKey(key, secondValue);
        var keyValuePair = _dictionaryStore.GetDitionayValueByKey(key);
        //Assert
        Assert.AreEqual(secondValue, keyValuePair);
    }

}
