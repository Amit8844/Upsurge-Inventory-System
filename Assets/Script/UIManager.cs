
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UpSurge
{
    public class UIManager : MonoBehaviour
    {
        public GameObject HowToPlayPanel;

        public void StartButton()
        {
            SceneManager.LoadScene("GameScene");
        }
        public void HowToPlay()
        {
            HowToPlayPanel.SetActive(true);
        }
        public void QuitGame()
        {
            SceneManager.LoadScene("Home");
        }
    }
}
