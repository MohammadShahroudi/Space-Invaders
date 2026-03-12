using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class Credits : MonoBehaviour
{
    float timer = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 5.0f)
        {
            LoadScene();
        }
    }
    
    public void LoadScene()
    {
        // SceneManager.LoadScene("Game");
        StartCoroutine(_LoadScene());
    }

    IEnumerator _LoadScene()
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync("Main_menu");
        while (!loadOperation!.isDone) yield return null;
    }
}
