using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �A�N�Z�X��1�񂫂�Ȃ̂ŁA�t�B�[���h�ϐ���p�ӂ��Ȃ��Ă�����
        Text myText = GetComponent<Text>();
        // text�ɋ�̕������ݒ肷��
        myText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
