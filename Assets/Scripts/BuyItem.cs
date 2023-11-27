using UnityEngine;

public class BuyItem : MonoBehaviour
{
    private IStore _store;

    void Start()
    {
        _store = StoreFactory.GetStore();
    }

   public void Buy(string itemId)
    {
        _store.PurchaseItem(itemId);
    }
}