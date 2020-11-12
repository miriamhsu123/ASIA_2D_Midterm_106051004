using UnityEngine;
using UnityEngine.SceneManagement;

public class settingManager : MonoBehaviour
{
   
    public void NextLevel()
    {
        print("下一關");
    }

    public void Try1Again()
    {
        print("再試一次Lv1");
        SceneManager.LoadScene("level_1");
    }
    
    
    public void ReturnToMenu()
    {
        print("返回選單");
        SceneManager.LoadScene("menu");
    }
    
    public void QuitGame()
    {
        print("離開遊戲");
        Application.Quit();
    }
}
