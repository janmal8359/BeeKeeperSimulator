using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleSystemManager : MonoBehaviour
{
    public Button btnStart;
    public Button btnSet;
    public Button btnExit;

    public string mainSceneName = "";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (btnStart == null) return;
        if (btnSet == null) return;
        if (btnExit == null) return;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnClickExit();
        }
    }

    // Button Setting
    public void OnClickStart()
    {
        // Change Scene
        SceneManager.LoadSceneAsync(mainSceneName);
    }

    public void OnClickSet()
    {
        // Open Setting UI
        Debug.LogWarning("Click the Setting Button");
    }

    public void OnClickExit()
    {
        // Exit of Game

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif

    }
}
