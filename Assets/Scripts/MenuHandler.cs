using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuHandler : MonoBehaviour
{
    [SerializeField] private InputField playerName;

    private void Start()
    {
        playerName = GetComponentInChildren<InputField>();
        playerName.onEndEdit.AddListener(SubmitName);
    }

    public void SaveNameAndStart()
    {
        string name = playerName.text;
        Debug.Log("Player name: " + name);
        DataManager.Instance.SetName(name);
        SceneManager.LoadScene(0);
    }

    private void SubmitName(string s)
    {
        playerName.text = s;
    }
}
