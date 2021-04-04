using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int stage = 0;
    public int stageItemCount;
    public Text stageText;
    public Text stageItemCountText;
    public Text playerItemCountText;

    private void Awake()
    {
        // stageItemCountText.text = "/ " + stageItemCount;
        stageText.text = "Stage : " + (stage+1);
    }

    public void updateScoreText(int score)
    {
        playerItemCountText.text = score.ToString(); 
    }

    public void checkClearSatage(int score)
    {
        if (score < stageItemCount)
        {
            SceneManager.LoadScene(stage);
        } else if (score == stageItemCount)
        {
            SceneManager.LoadScene(++stage);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(stage);
    }
}
