﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class Controlador : MonoBehaviour {

    #region Private Vars
    private int score;
    private int faseAtual;
    #endregion

    #region Public Vars
    /// <summary>
    /// Singleton Simples
    /// </summary>
    public static Controlador controlador;

    public int _score { get { return score; } }
    public int _faseAtual { get { return faseAtual; } }
    #endregion

    void Awake()
    {
        controlador = GetComponent<Controlador>();
    }

    public void SetScore(int x)
    {
        score += x;
    }



}
