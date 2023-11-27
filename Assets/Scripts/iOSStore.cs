#if UNITY_IOS
using UnityEngine;

public class iOSStore : IStore
{
    public void PurchaseItem(string itemId)
    {
        // Логика покупки для iOS
        Debug.Log($"Предмет с ID {itemId} куплен в AppStore");
    }
    // Реализация других методов
}

#endif