using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;  //ź�� �ӷ�
    private Rigidbody bulletRigidbody;  // �̵��� ����� ������ٵ� ������Ʈ

    void Start()
    {
        //���� ������Ʈ���� rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other) //Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
    {
        if(other.tag == "Player")//�浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
        {
            PlayerController playerController = other.GetComponent<PlayerController>();//���� ���� ������Ʈ���� PlayerController ������Ʈ ��������

            if(playerController != null)// �������κ��� playerController ������Ʈ�� �������µ� �����ߴٸ�
            {
                playerController.Die(); //���� PlayerController ������Ʈ�� Die() �޼��� ����
            }
        }
    }
}
