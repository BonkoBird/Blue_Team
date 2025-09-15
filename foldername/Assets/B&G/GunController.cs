using UnityEngine;

public class GunController : MonoBehaviour
{
    void Update()
    {
        // 获取鼠标位置
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0; // 保持在 2D 平面

        // 计算方向
        Vector3 direction = mousePos - transform.position;

        // 算出角度
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // 设置旋转
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
