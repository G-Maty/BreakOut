using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // �����ƂԂ��������ɌĂ΂��r���g�C�����\�b�h
    void OnCollisionEnter(Collision collision)
    {
        // �Q�[���I�u�W�F�N�g���폜���郁�\�b�h
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
