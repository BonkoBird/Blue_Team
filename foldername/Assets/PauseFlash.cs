using UnityEngine;
using UnityEngine.UI;

public class PauseFlash : MonoBehaviour
{
    private bool isPaused = false;

    [Header("UI")]
    [SerializeField] private Button pauseButton;   // 按钮 (可选)
    [SerializeField] private Sprite pauseIcon;     // 暂停图标 (||)
    [SerializeField] private Sprite playIcon;      // 播放图标 (▶)
    [SerializeField] private GameObject pauseMenu; // 暂停菜单 Canvas

    private Image buttonImage;

    void Start()
    {
        if (pauseButton != null)
        {
            pauseButton.onClick.AddListener(TogglePause);
            buttonImage = pauseButton.GetComponent<Image>();

            // 默认显示暂停图标
            if (buttonImage != null && pauseIcon != null)
                buttonImage.sprite = pauseIcon;
        }

        // 开始时隐藏菜单
        if (pauseMenu != null)
            pauseMenu.SetActive(false);
    }

    void Update()
    {
        // 监听 Esc 键
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;

        // 切换按钮图片
        if (buttonImage != null)
        {
            buttonImage.sprite = isPaused ? playIcon : pauseIcon;
        }

        // 显示/隐藏暂停菜单
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(isPaused);
        }

        Debug.Log("Your Status: " + (isPaused ? "Stop" : "Continue"));
    }

    // Resume 按钮调用
    public void ResumeGame()
    {
        if (isPaused)
            TogglePause();
    }

    // Quit 按钮调用
    public void QuitGame()
    {
        Debug.Log("End of game");
        Application.Quit();

        // 如果在编辑器里测试，可以这样退出
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}