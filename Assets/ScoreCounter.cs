using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    
    //獲得した得点
    private int score = 0;

    //合計獲得得点
    private int scoresum = 0;

    //得点を表示するテキスト
    private GameObject scorecounterText;
    

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
        this.scorecounterText = GameObject.Find("ScoreText");

        AddScore();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //ターゲット衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {

        //ターゲット毎に得点を変える
        string tag = collision.gameObject.tag;

        //SmallSterに衝突時に獲得する得点
        if (tag == "SmallStarTag")
        {
            this.score =+ 5;
        }

        //LargeSterに衝突時に獲得する得点
        else if (tag == "LargeStarTag")
        {
            this.score =+ 15;
        }

        //SmallCloudに衝突時に獲得する得点
        else if (tag == "SmallCloudTag")
        {
            this.score =+ 20;
        }

        //LargeCloudに衝突時に獲得する得点
        else if (tag == "LargeCloudTag")
        {
            this.score =+ 50;
        }

        //ターゲット以外衝突時
        else
        {
            this.score = 0;
        }

        //獲得した得点をscoresumに加算する
        this.scoresum += this.score;

        AddScore();

    }

    //ScoreTextに得点を表示
    void AddScore()
    {
        this.scorecounterText.GetComponent<Text>().text = "Score:" + (this.scoresum);
    }
}
