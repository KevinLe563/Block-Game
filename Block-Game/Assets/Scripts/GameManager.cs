using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    public float restartDelay = 2f;
    public GameObject gameOverUI;
    bool gameHasEnded = false;
    public void GameOver () {
        
        if (gameHasEnded == false) {
            gameHasEnded = true;
            gameOverUI.SetActive(true);
            Invoke("RestartGame", restartDelay);
        }

    }

    void RestartGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
