﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public QRReader qrReader;
    public TextElement textElement;
    [HideInInspector] public List<UIElement> activeElements;
    public static UIManager Instance { get { return _instance; } }
    private static UIManager _instance;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    private void Start()
    {
        StartQRReader();
    }

    private void StartQRReader()
    {
        //create qrreader
        if (!activeElements.Contains(qrReader))
        {
            QRReader reader = Instantiate(qrReader, gameObject.transform, false);
            activeElements.Add(qrReader);
            reader.Setup();
        }
    }

}