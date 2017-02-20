using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scoreplayer : MonoBehaviour
{
    public Text scoreText;
    private int score;


    GameObject Player;
    BossController bossController;

    // Use this for initialization
    void Start ()
    {
        Player = GameObject.Find("gamecontroller ");
        bossController = Player.GetComponent<BossController>();
        score = 0;
        UpdateScore();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(score == 50)
        {
            BossGo();
        }

    }

    public void addscore(int newScoreValus)
    {
        score += newScoreValus;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score : " + score.ToString();
    }

    protected void BossGo()
    {

        bossController.enabled = true;
    }

}
