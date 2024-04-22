using UnityEngine;
using UnityEngine.UI;

public class Fps : MonoBehaviour
{
    public Text displayText;
    public float hudRefreshRate = 1f;

    private float timer;

    private void Update()
    {
        if (Time.unscaledTime > timer)
        {
            int fps = (int)(1f / Time.unscaledDeltaTime);
            displayText.text = fps + " FPS";
            timer = Time.unscaledTime + hudRefreshRate;
        }
    }
}
