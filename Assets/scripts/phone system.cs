using UnityEngine;
using TMPro;
using System.Collections;

public class phonesystem : MonoBehaviour
{
    public GameObject phoneUI;
    public TextMeshProUGUI messageText;

    public float typingSpeed = 0.03f;

    public void ShowMessage(string message)
    {
        phoneUI.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(TypeMessage(message));
    }

    IEnumerator TypeMessage(string message)
    {
        messageText.text = "";

        foreach (char c in message)
        {
            messageText.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void HidePhone()
    {
        phoneUI.SetActive(false);
    }
}
