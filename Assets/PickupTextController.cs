using System.Collections;
using UnityEngine;
using TMPro;

public class PickupTextController : MonoBehaviour
{
    public float seconds;
    private TextMeshProUGUI textMeshProUGUI;

    private void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        ShowText(false);
    }

    public void OnPickupEventResponse()
    {
        StartCoroutine(ShowTextCoroutine());
    }

    private IEnumerator ShowTextCoroutine()
    {
        ShowText(true);
        yield return new WaitForSeconds(seconds);
        ShowText(false);
    }

    public void ShowText(bool show)
    {
        textMeshProUGUI.enabled = show;
    }
}
