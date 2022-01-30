using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{
    public void PrevScene()
    {
        try
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        catch (System.Exception e)
        {
            Debug.LogError(e.ToString());
            throw;
        }
    }

    public void NextSceneDelay(float t)
    {
        StartCoroutine(WaitForNext(t));
    }

    IEnumerator WaitForNext(float t)
    {
        GameObject.Find("EventSystem").SetActive(false);
        yield return new WaitForSeconds(t);
        NextScene();
    }

    public void NextScene()
    {
        try
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        catch (System.Exception e)
        {
            Debug.LogError(e.ToString());
            throw;
        }
        
    }

    public void RestartScene()
    {
        Time.timeScale = 1;
        Application.LoadLevel(Application.loadedLevel);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

}
