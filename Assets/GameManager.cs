using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
   // public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject menuUI;
    public GameObject scoreUI;
    public void CompleteLevel()
    {
        //Debug.Log("Level Won");
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            menuUI.SetActive(true);
            scoreUI.SetActive(false);
           //Invoke("Restart", restartDelay);
        }
    }

   /*void Restart()
    {
        //SceneManager.LoadScene("Level01");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/
}
