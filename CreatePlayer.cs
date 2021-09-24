using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEditor.SceneManagement;

public class CreatePlayer : MonoBehaviour
{
    private BasePlayerClass newPlayer;
    private string playerName = "";

    //UI
    public Text combateText;
    public Text habilidadesText;
    public Text suporteText;
    public Text saudeText;

    private int pointsToSpend = 20;
    public Text pointsText;

    // Start is called before the first frame update
    void Start()
    {
        newPlayer = new BasePlayerClass();
        UpdateUI();
    }

    public void CreateNewPlayer()
    {
        newPlayer.PlayerLevel = 1;
        newPlayer.PlayerName = playerName;

        GameInfo.PlayerLevel = newPlayer.PlayerLevel;
        GameInfo.PlayerName = newPlayer.PlayerName;
        GameInfo.PlayerClass = newPlayer.PlayerClass;

        GameInfo.Combate = newPlayer.Combate;
        GameInfo.Habilidades = newPlayer.Habilidades;
        GameInfo.Suporte = newPlayer.Suporte;
        GameInfo.Saude = newPlayer.Saude;

        SaveInfo.SaveAllInfo();

        EditorSceneManager.LoadScene("TestScene");
    }

    public void SetUnnamedClass1()
    {
        pointsToSpend = 20;
        newPlayer.PlayerClass = new BaseUnnamedClass1();
        newPlayer.Combate = newPlayer.PlayerClass.Combate;
        newPlayer.Habilidades = newPlayer.PlayerClass.Habilidades;
        newPlayer.Suporte = newPlayer.PlayerClass.Suporte;
        newPlayer.Saude = newPlayer.PlayerClass.Saude;     

        UpdateUI();
    }

    public void SetUnnamedClass2()
    {
        pointsToSpend = 20;
        newPlayer.PlayerClass = new BaseUnnamedClass2();
        newPlayer.Combate = newPlayer.PlayerClass.Combate;
        newPlayer.Habilidades = newPlayer.PlayerClass.Habilidades;
        newPlayer.Suporte = newPlayer.PlayerClass.Suporte;
        newPlayer.Saude = newPlayer.PlayerClass.Saude;
      

        UpdateUI();
    }

    public void SetUnnamedClass3()
    {
        pointsToSpend = 20;
        newPlayer.PlayerClass = new BaseUnnamedClass3();
        newPlayer.Combate = newPlayer.PlayerClass.Combate;
        newPlayer.Habilidades = newPlayer.PlayerClass.Habilidades;
        newPlayer.Suporte = newPlayer.PlayerClass.Suporte;
        newPlayer.Saude = newPlayer.PlayerClass.Saude;

        
        UpdateUI();

    }

    void UpdateUI()
    {
        combateText.text = newPlayer.Combate.ToString();
        habilidadesText.text = newPlayer.Habilidades.ToString();
        suporteText.text = newPlayer.Suporte.ToString();
        saudeText.text = newPlayer.Saude.ToString();

        pointsText.text = pointsToSpend.ToString();
    }

    public void SetCombate(int amount)
    {
        if(newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Combate += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Combate > newPlayer.PlayerClass.Combate)
            {
                newPlayer.Combate += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }
    public void SetHabilidades(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Habilidades += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Habilidades > newPlayer.PlayerClass.Habilidades)
            {
                newPlayer.Habilidades += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }
    public void SetSuporte(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Suporte += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Suporte > newPlayer.PlayerClass.Suporte)
            {
                newPlayer.Suporte += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }
    public void SetSaude(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Saude += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Saude > newPlayer.PlayerClass.Saude)
            {
                newPlayer.Saude += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }
   
    public void LoadStuff()
    {
        LoadInfo.LoadAllInfo();
        EditorSceneManager.LoadScene("TestScene");
            
    }
}
