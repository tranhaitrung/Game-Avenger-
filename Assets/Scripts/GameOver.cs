using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUIManagement : MonoBehaviour
{

    public void MoveToSelectLevel() {
        SceneManager.LoadScene(8);
    }

    public void TryAgain() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}