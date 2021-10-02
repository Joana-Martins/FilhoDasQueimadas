using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        Debug.Log(saude);
        if (GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
    }

    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    public PlayerController player;
    public FloatingTextManager floatingTextManager;

    private string playerName = GameInfo.PlayerName;
    private int gold;
    private int exp;
    private int combate = GameInfo.Combate;
    private int suporte = GameInfo.Suporte;
    private int habilidades = GameInfo.Habilidades;
    private int saude = GameInfo.Saude;

    

    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
    }
    /*
     *  INT skin
     *  INT gold
     *  
     *  PlayerPrefs.SetString("PLAYERNAME", GameInfo.PlayerName);
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInfo.PlayerLevel);
        //
        PlayerPrefs.SetInt("COMBATE", GameInfo.Combate);
        PlayerPrefs.SetInt("HABILIDADES", GameInfo.Habilidades);
        PlayerPrefs.SetInt("SUPORTE", GameInfo.Suporte);
        PlayerPrefs.SetInt("SAUDE", GameInfo.Saude);
     * 
     * 
     */
    public void SaveState()
    {
        string s = "";

        s += "0" + "|";
        s += gold.ToString() + "|";
        s += exp.ToString() + "|";
        s += combate.ToString() + "|";
        s += habilidades.ToString() + "|";
        s += suporte.ToString() + "|";
        s += saude.ToString() + "|";

        PlayerPrefs.SetString("SaveState", s);      
    }

    public void LoadState(Scene s, LoadSceneMode mode)
    {

        if (!PlayerPrefs.HasKey("SaveState"))
            return;
        string[] data = PlayerPrefs.GetString("SaveState").Split('|');

        gold = int.Parse(data[1]);
        exp = int.Parse(data[2]);
        combate = int.Parse(data[3]);
        habilidades = int.Parse(data[4]);
        suporte = int.Parse(data[5]);
        saude = int.Parse(data[6]);
    }
    
}
