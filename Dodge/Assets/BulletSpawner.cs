using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; // 생성할 탄알의 원본 프리팹
    public float spawnRateMin = 0.5f;  // 최소 생성 주기
    public float spawnRateMax = 3f;  // 최대 생성 주기

    private Transform target;  // 발사할 대상
    private float spawnRate;  // 생성 주기
    private float timeAfterSpawn;  // 최근 생성 시점에서 지난 시간
        
    
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

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation); //총알 복제본을 총알생성기 포지션, 로테이션 위치에 생성
            bullet.transform.LookAt(target); //총알 정면 방향이 타겟을 향하도록 회전

            spawnRate = Random.Range(spawnRateMin, spawnRateMax); //다음번 생성 주기 랜덤 결정
        }
    }
}
