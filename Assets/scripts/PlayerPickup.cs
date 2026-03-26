using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public float pickupDistance = 3f;
    public Camera playerCamera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryPickup();
        }
    }

    void TryPickup()
    {
        Ray ray = playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, pickupDistance))
        {
            PickableItem item = hit.collider.GetComponent<PickableItem>();

            if (item != null)
            {
                item.OnPickup();
            }
        }
    }
}
