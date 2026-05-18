using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class IntroSequence : MonoBehaviour
{
    public Image blackScreen;
    public TextMeshProUGUI introText;
    public float fadeSpeed = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(PlayIntro());
    }
    IEnumerator PlayIntro()
    {
        SetAlpha(blackScreen, 1f);
        introText.text = "";
        yield return new WaitForSeconds(1.5f);
        string message = "Отец моего друга Карсон попросил присмотреть за их домом пока они в отьезде.";
        yield return; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
