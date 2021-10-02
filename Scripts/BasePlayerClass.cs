using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayerClass
{
    private string playerName;
    private int playerLevel;
    private BaseClass playerClass;

    private int combate;
    private int habilidades;
    private int suporte;
    private int saude;

    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }

    public BaseClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
    }
    public int Combate
    {
        get { return combate; }
        set { combate = value; }
    }
    public int Habilidades
    {
        get { return habilidades; }
        set { habilidades = value; }
    }

    public int Suporte
    {
        get { return suporte; }
        set { suporte = value; }
    }

    public int Saude
    {
        get { return saude; }
        set { saude = value; }
    }
}
 