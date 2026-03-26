using UnityEngine;

public class flashinglights : MonoBehaviour
{
    public Light lightSource;
    public float minTime = 0.05f;
    public float maxTime = 0.3f;

    void Start()
    {
        InvokeRepeating("Flicker", 0f, Random.Range(minTime, maxTime));
    }

    void Flicker()
    {
        lightSource.enabled = !lightSource.enabled;
    }
}
