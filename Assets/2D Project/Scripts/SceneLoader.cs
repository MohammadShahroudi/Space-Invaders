using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoaderLive : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    
	public void LoadGame()
    {
		StartCoroutine(_LoadGame());

        IEnumerator _LoadGame()
        {
            AsyncOperation loadOperation = SceneManager.LoadSceneAsync("Schmup");
			// AsyncOperation loadOperation = SceneManager.LoadSceneAsync("Credits");

            while (!loadOperation!.isDone) yield return null;
        
            // wait until scene is loaded and ready and then find the player
            GameObject playerObj = GameObject.Find("Player");
            Debug.Log(playerObj.name);
        }
    }

    /*public void _LoadCredits()
    {
        // SceneManager.LoadScene("Game");
        StartCoroutine(_LoadCredits());

        IEnumerator _LoadCredits()
        {
            AsyncOperation loadOperation = SceneManager.LoadSceneAsync("Credits");
            while (!loadOperation!.isDone) yield return null;
        
            // wait until scene is loaded and ready and then find the player
            GameObject playerObj = GameObject.Find("Player");
            Debug.Log(playerObj.name);
        }
    }*/
}
