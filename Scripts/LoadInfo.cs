using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInfo : MonoBehaviour
{
    public static void LoadAllInfo()
    {
        GameInfo.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInfo.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");

        GameInfo.Combate = PlayerPrefs.GetInt("COMBATE");
        GameInfo.Habilidades = PlayerPrefs.GetInt("HABILIDADES");
        GameInfo.Suporte = PlayerPrefs.GetInt("SUPORTE");
        GameInfo.Saude = PlayerPrefs.GetInt("SAUDE");

        Debug.Log(GameInfo.Combate);
        Debug.Log("Info Loaded");
    }
}
