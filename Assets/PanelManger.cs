using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.LogicCore;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class PanelManger : MonoBehaviour
{
    [FormerlySerializedAs("_mainPanel")]
    [SerializeField]
    private GameObject _exponatInfoPanel;

    private FollowMeToggle _followMe;

    [SerializeField]
    [Range(1, 10)]
    private float _distance;

    [SerializeField]
    private TextMeshPro _title;
    [SerializeField]
    private TextMeshPro _description;

    private static PanelManger _instance;

    private void Awake()
    {
        _instance = this;
        _followMe = GetComponent<FollowMeToggle>();
        HideExponatInfoPanel();
    }

    public void HideExponatInfoPanel()
    {
        _exponatInfoPanel.SetActive(false);
    }

    public static void ExponatClicked(ExponentContent ec)
    {
        _instance.ShowExponatInfoPanel(ec);
    }

    public void ShowExponatInfoPanel(ExponentContent content=null)
    {
        _followMe.AutoFollowDistance = _distance;
        _followMe.SetFollowMeBehavior(true);
        if (content != null)
           _title.text=  content.Name;
           _description.text = content.Description;


        _exponatInfoPanel.SetActive(true);
    }
}
