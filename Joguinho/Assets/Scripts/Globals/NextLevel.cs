using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Cinemachine.DocumentationSortingAttribute;

public class NextLevel : MonoBehaviour
{
    public GameObject nextLevel;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            nextLevel.SetActive(true);
        }
    }

    public void LevelFinished()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
}
