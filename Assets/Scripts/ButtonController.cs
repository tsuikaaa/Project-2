using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI m_Title;

    [SerializeField]
    private Image m_Icon;

    [SerializeField]
    private string m_Text = "Button";

    [SerializeField]
    private Sprite m_Sprite;

    void Start()
    {
        m_Title.text = m_Text;
        m_Icon.sprite = m_Sprite;
    }

    void Update()
    {

    }
}