using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    public Text gameClearMessage;
    Transform myTransform;
    // ゲームクリアしたかどうかを管理するフラグを用意
    bool isGameClear = false;
    // Start is called before the first frame update
    void Start()
    {
        // Transformコンポーネントを保持しておく
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        // 子供がいなくなったらゲームを停止する
        if (myTransform.childCount == 0)
        {
            gameClearMessage.text = "Game Clear";
            Time.timeScale = 0f;
            // ゲームクリアのフラグを立てる
            isGameClear = true;
        }

        // ゲームクリアしている、かつ、ボタン入力でシーンを再ロード
        if (isGameClear && Input.GetButtonDown("Submit"))
        {
            // timeScaleを1に戻しておく
            Time.timeScale = 1f;
            // シーンのロード
            SceneManager.LoadScene("Play");
        }
    }
}
