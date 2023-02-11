using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;

   private void Awake()
    {
        gameOverScreen.SetActive(true);
    }


    public void MoveToSelectLevel() {
        SceneManager.LoadScene(8);
    }

    public void TryAgain() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
