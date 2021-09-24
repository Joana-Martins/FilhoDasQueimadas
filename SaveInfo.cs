using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfo : MonoBehaviour
{
    public static void SaveAllInfo()
    {
        PlayerPrefs.SetString("PLAYERNAME", GameInfo.PlayerName);
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInfo.PlayerLevel);
        //
        PlayerPrefs.SetInt("COMBATE", GameInfo.Combate);
        PlayerPrefs.SetInt("HABILIDADES", GameInfo.Habilidades);
        PlayerPrefs.SetInt("SUPORTE", GameInfo.Suporte);
        PlayerPrefs.SetInt("SAUDE", GameInfo.Saude);
    }
}
