using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; // ������ ź���� ���� ������
    public float spawnRateMin = 0.5f;  // �ּ� ���� �ֱ�
    public float spawnRateMax = 3f;  // �ִ� ���� �ֱ�

    private Transform target;  // �߻��� ���
    private float spawnRate;  // ���� �ֱ�
    private float timeAfterSpawn;  // �ֱ� ���� �������� ���� �ð�
        
    
    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindObjectOfType<PlayerController>().transform;
    }

    
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if(timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation); //�Ѿ� �������� �Ѿ˻����� ������, �����̼� ��ġ�� ����
            bullet.transform.LookAt(target); //�Ѿ� ���� ������ Ÿ���� ���ϵ��� ȸ��

            spawnRate = Random.Range(spawnRateMin, spawnRateMax); //������ ���� �ֱ� ���� ����
        }
    }
}
