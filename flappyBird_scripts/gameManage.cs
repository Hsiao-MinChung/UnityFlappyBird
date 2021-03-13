using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManage : MonoBehaviour
{
    public GameObject gameOverCanvas;//死亡UI接口

   
    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.SetActive(false);//關閉死亡UI
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
    public void GameOver()
    {
        
        gameOverCanvas.SetActive(true);//開起死亡UI
        Time.timeScale = 0;//時間暫停
    }

    public void gameReply()//遊戲重來
    {
        SceneManager.LoadScene(1);

    }


    public void backToStart()//轉場到主畫面
    {
        SceneManager.LoadScene(0);
    }

}
