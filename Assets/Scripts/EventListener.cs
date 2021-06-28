using UnityEngine;

public class EventListener : MonoBehaviour
{
    public EventTrigger eventTrigger;
    public UnityEventGameObject unityEvent = new UnityEventGameObject();

    private void OnEnable()
    {
        eventTrigger.AddEventListener(this);
    }

    private void OnDisable()
    {
        eventTrigger.RemoveEventListener(this);
    }

    public void OnEventTrigger(GameObject gameObject)
    {
        unityEvent.Invoke(gameObject);
    }
}
