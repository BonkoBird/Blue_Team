using UnityEngine;
using UnityEngine.SceneManagement;

public class jumptothescene : MonoBehaviour
{
    // 输入需要跳转的scene名字
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
