using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;  //�̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f;  //�̵� �ӷ�

    
    void Start() //���� ���� ���۵Ǵ� �޼���
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }

   
 
    void Update()    //�������� ���� ������ �ӵ��� ���ŵ�
    {
        
        //������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ����Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //vector3 �ӵ��� (xSpeed, 0, zSpeed)�� ����
        Vector3 newVelocy = new Vector3(xSpeed, 0f, zSpeed);
        //������ٵ��� �ӵ��� newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocy;
        //playerRigidbody.velocity = new Vector3(xInput, 0.0f, zInput) * speed;
    }

    public void Die()
    {
        //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        this.gameObject.SetActive(false);
    }
}