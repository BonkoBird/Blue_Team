
using UnityEngine;
public class spacestop : MonoBehaviour
{
private bool isPaused = false;
void Update()
{
if (Input.GetKeyDown(KeyCode.Space))
{
isPaused = !isPaused;
Time.timeScale = isPaused ? 0 : 1;
}
}
}
