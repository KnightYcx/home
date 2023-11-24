using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public bool  isgameover;
    [SerializeField] private TMP_Text scoretext;
    [SerializeField] private GameObject gameovermenu;
    [SerializeField] private TMP_Text gameoverScoreText;
    [SerializeField] private TMP_Text gameoverBestScoreText;
    
    //[SerializeField] private GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Addscore()
    {     
        score ++;
        scoretext.text = score.ToString();
    }
    public void setGameover()
    {
        isgameover = true;
        gameovermenu.SetActive(true);
        int scorebest = PlayerPrefs.GetInt("Bestscore",0);
        if (scorebest<score)
        {
            scorebest = score;
            PlayerPrefs.SetInt("Bestscore", scorebest);
        }
        gameoverScoreText.text = "score:"+score.ToString();
        gameoverBestScoreText.text = "best score:"+scorebest.ToString();
    }
    public void retry()
    {
        SceneManager.LoadScene("game_secens");
    }
    public void exit()
    {
        Application.Quit();
    }
}
