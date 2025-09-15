using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;  // 子弹预制体
    public Transform firePoint;      // 枪口位置
    public float fireDelay = 0.3f;   // 射击间隔

    private float nextFireTime = 0f;

    void Update()
    {
        // W键发射
        if (Input.GetKey(KeyCode.W) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireDelay;
            Debug.Log("shoot it");

        }
    }

    void Shoot()
    {
        if (bulletPrefab != null && firePoint != null)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
