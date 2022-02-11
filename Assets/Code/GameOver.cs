using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // public�ɂ���Inspector����ݒ�ł���悤�ɂ���
    public Text gameOverMessage;
    // �Q�[���I�[�o�[�������ǂ����𔻒f���邽�߂̕ϐ�
    bool isGameOver = false;

    // �Փˎ��ɌĂ΂��
    void OnCollisionEnter(Collision collision)
    {
        // Game Over�ƕ\������
        gameOverMessage.text = "Game Over";
        // ���������Q�[���I�u�W�F�N�g���폜����
        Destroy(collision.gameObject);
        // isGameOver��true�ɂ���i�t���O�𗧂Ă�j
        isGameOver = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �Q�[���I�[�o�[�ɂȂ��Ă���A���ASubmit�{�^��������������s����
        if (isGameOver && Input.GetButtonDown("Submit"))
        {
            // Play�V�[�������[�h����
            SceneManager.LoadScene("Play");
        }
    }
}
