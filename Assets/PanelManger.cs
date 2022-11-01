using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManger : MonoBehaviour
{
    [SerializeField]
    private GameObject _mainPanel;

    public void ShowMainPanel()
    {
        Debug.Log($"Method is called");

        _mainPanel.SetActive(true);
    }
}
