using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass
{
    private int combate;
    private int habilidades;
    private int suporte;
    private int saude;

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