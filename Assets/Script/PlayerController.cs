using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�d��
    Rigidbody2D rigidbody2D;
    //�W�����v���鎞�̗�
    float jumpForce = 680.0f;
    // Start is called before the first frame update
    void Start()
    {
        //�t���[���J�E���g
        Application.targetFrameRate = 60;
        //Rigdbody���R���|�[�l���g
        this.rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //�W�����v����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigidbody2D.AddForce(transform.up * this.jumpForce);
        }
    }
}
