using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TMP_InputField nameText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Best Score : " + DataManager.Instance.userName + " : " + DataManager.Instance.highScore;
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    public void SaveName()
    {
        DataManager.Instance.tempName = nameText.text;
    }
}
