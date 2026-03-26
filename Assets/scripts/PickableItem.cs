using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public string itemName;

    public void OnPickup()
    {
        Debug.Log("Picked up: " + itemName);
        Destroy(gameObject);
    }
}
