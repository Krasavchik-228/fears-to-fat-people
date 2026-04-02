using Unity.VisualScripting;
using UnityEngine;

public class pickup : MonoBehaviour
{
    [SerializeField] float rayDis = 2;
    [SerializeField] LayerMask mask;
    public GameObject selectedObject;
    // start is called once before the first execution of Update after the MonoBehaviour is created. zzzzz
    void Start()
    {
        
    }

    // update is called once per frame.
    void Update()
    {
        RaycastHit hit;
        Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward, out hit, rayDis, mask);
        print(hit.collider);
        if(hit.collider != null)
        {
            if(hit.collider.CompareTag("Selectable"))
            {
                selectedObject = hit.collider.gameObject;
            }
            else
            {
                selectedObject = null;
            }
        }
        else
        {
            selectedObject = null;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(Camera.main.transform.position,Camera.main.transform.forward * rayDis);
    }
}