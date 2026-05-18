using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class openScene : MonoBehaviour
{
    Button btn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(StartGame);
    }
    void StartGame()
    {
        SceneManager.LoadScene("Shop");
    }
}
