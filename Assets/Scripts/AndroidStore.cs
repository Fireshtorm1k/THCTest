using UnityEngine;

#if UNITY_ANDROID
public class AndroidStore : IStore
{
    public void PurchaseItem(string itemId)
    {
        // Логика покупки для Android
        Debug.Log($"Предмет с ID {itemId} куплен в GooglePlay");
    }
    // Реализация других методов
}
#endif