using TMPro;
using UnityEngine;

public class Chat : MonoBehaviour
{
    public static Chat Instance;

    [SerializeField] private TMP_Text _messages;

    private void Awake()
    {

        if (Instance == null)
            Instance = this;
        else if (Instance != null && Instance != this)
            Destroy(this);
    }

    public void SetMessage(string newMessage)
    {
        if (!string.IsNullOrEmpty(newMessage))
            _messages.text += newMessage;
    }
}
