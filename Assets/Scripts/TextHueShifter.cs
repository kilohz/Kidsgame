using UnityEngine;
using UnityEngine.UI;

public class TextHueShifter : MonoBehaviour
{
    public float Speed = 1;
    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.color = HSBColor.ToColor(new HSBColor(Mathf.PingPong(Time.time * Speed, 1), 1, 1));
    }
}
