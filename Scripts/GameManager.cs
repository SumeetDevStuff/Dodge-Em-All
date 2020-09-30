using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slowmotion = 10f;

    public void GameOver ()
    {
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel ()
    {
        Time.timeScale = 1f / slowmotion;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowmotion;

        yield return new WaitForSeconds(1f / slowmotion);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowmotion;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
