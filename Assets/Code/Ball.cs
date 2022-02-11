using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // �{�[���̈ړ��̑������w�肷��ϐ�
    public float speed = 5f;
    Rigidbody myRigidbody;
    // Transform�R���|�[�l���g��ێ����Ă������߂̕ϐ���ǉ�
    Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody�ɃA�N�Z�X���ĕϐ��ɕێ����Ă���
        myRigidbody = GetComponent<Rigidbody>();
        // �E�΂�45�x�ɐi��
        myRigidbody.velocity = new Vector3(speed, speed, 0f);
        // Transform�R���|�[�l���g���擾���ĕێ����Ă���
        myTransform = transform;
    }

    // �Փ˂����Ƃ��ɌĂ΂��
    void OnCollisionEnter(Collision collision)
    {
        // �v���C���[�ɓ��������Ƃ��ɁA���˕Ԃ������ς���
        if (collision.gameObject.CompareTag("Player"))
        {
            // �v���C���[�̈ʒu���擾
            Vector3 playerPos = collision.transform.position;
            // �{�[���̈ʒu���擾
            Vector3 ballPos = myTransform.position;
            // �v���C���[���猩���{�[���̕������v�Z
            Vector3 direction = (ballPos - playerPos).normalized;
            // ���݂̑������擾
            float speed = myRigidbody.velocity.magnitude;
            // ���x��ύX
            myRigidbody.velocity = direction * speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
