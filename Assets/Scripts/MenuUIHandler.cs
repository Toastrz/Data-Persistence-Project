using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] InputField PlayerInputField;

    public void StartNew()
    {
        SavePlayerName();
        SceneManager.LoadScene(1);
    }

    private void SavePlayerName()
    {
        if (string.IsNullOrEmpty(PlayerInputField.text)) return;
        DataPersistence.Instance.PlayerName = PlayerInputField.text;
    }

    public void Exit()
    {
        
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}