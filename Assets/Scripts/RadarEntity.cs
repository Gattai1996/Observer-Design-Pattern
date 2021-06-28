using UnityEngine;
using UnityEngine.UI;

public class RadarEntity : MonoBehaviour
{
    public Image image;
    public EventTrigger onSpawnEventTrigger;
    public EventTrigger onPickupEventTrigger;

    private void Awake()
    {
        onSpawnEventTrigger.Trigger(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            onPickupEventTrigger.Trigger(gameObject);
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            Destroy(gameObject, 5f);
        }
    }
}
