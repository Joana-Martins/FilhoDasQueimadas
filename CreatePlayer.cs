using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePlayer : MonoBehaviour
{
    private BasePlayerClass newPlayer;

    //UI
    public Text atletismoText;
    public Text pilotagemText;
    public Text roubarText;
    public Text saudeText;

    public Text infiltracaoText;
    public Text mecanicaText;
    public Text medicoText;
    public Text preparoText;

    public Text lutaText;
    public Text atirarText;
    public Text terapiaText;
    public Text sanidadeText;
    public Text vigilanciaText;

    private int pointsToSpend = 20;
    public Text pointsText;

    // Start is called before the first frame update
    void Start()
    {
        newPlayer = new BasePlayerClass();  
    }

    public void SetUnnamedClass1()
    {
        pointsToSpend = 20;
        newPlayer.PlayerClass = new BaseUnnamedClass1();
        newPlayer.Atletismo = newPlayer.PlayerClass.Atletismo;
        newPlayer.Pilotagem = newPlayer.PlayerClass.Pilotagem;
        newPlayer.Roubar = newPlayer.PlayerClass.Roubar;
        newPlayer.Saude = newPlayer.PlayerClass.Saude;
        newPlayer.Infiltracao = newPlayer.PlayerClass.Infiltracao;
        newPlayer.Mecanica = newPlayer.PlayerClass.Mecanica;
        newPlayer.Medico = newPlayer.PlayerClass.Medico;
        newPlayer.Preparo = newPlayer.PlayerClass.Preparo;
        newPlayer.Luta = newPlayer.PlayerClass.Luta;
        newPlayer.Atirar = newPlayer.PlayerClass.Atirar;
        newPlayer.Terapia = newPlayer.PlayerClass.Terapia;
        newPlayer.Sanidade = newPlayer.PlayerClass.Sanidade;
        newPlayer.Vigilancia = newPlayer.PlayerClass.Vigilancia;

        UpdateUI();
    }

    public void SetUnnamedClass2()
    {
        pointsToSpend = 20;
        newPlayer.PlayerClass = new BaseUnnamedClass2();
        newPlayer.Atletismo = newPlayer.PlayerClass.Atletismo;
        newPlayer.Pilotagem = newPlayer.PlayerClass.Pilotagem;
        newPlayer.Roubar = newPlayer.PlayerClass.Roubar;
        newPlayer.Saude = newPlayer.PlayerClass.Saude;
        newPlayer.Infiltracao = newPlayer.PlayerClass.Infiltracao;
        newPlayer.Mecanica = newPlayer.PlayerClass.Mecanica;
        newPlayer.Medico = newPlayer.PlayerClass.Medico;
        newPlayer.Preparo = newPlayer.PlayerClass.Preparo;
        newPlayer.Luta = newPlayer.PlayerClass.Luta;
        newPlayer.Atirar = newPlayer.PlayerClass.Atirar;
        newPlayer.Terapia = newPlayer.PlayerClass.Terapia;
        newPlayer.Sanidade = newPlayer.PlayerClass.Sanidade;
        newPlayer.Vigilancia = newPlayer.PlayerClass.Vigilancia;

        UpdateUI();
    }

    public void SetUnnamedClass3()
    {
        pointsToSpend = 20;
        newPlayer.PlayerClass = new BaseUnnamedClass3();
        newPlayer.Atletismo = newPlayer.PlayerClass.Atletismo;
        newPlayer.Pilotagem = newPlayer.PlayerClass.Pilotagem;
        newPlayer.Roubar = newPlayer.PlayerClass.Roubar;
        newPlayer.Saude = newPlayer.PlayerClass.Saude;

        newPlayer.Infiltracao = newPlayer.PlayerClass.Infiltracao;
        newPlayer.Mecanica = newPlayer.PlayerClass.Mecanica;
        newPlayer.Medico = newPlayer.PlayerClass.Medico;
        newPlayer.Preparo = newPlayer.PlayerClass.Preparo;
        newPlayer.Luta = newPlayer.PlayerClass.Luta;

        newPlayer.Atirar = newPlayer.PlayerClass.Atirar;
        newPlayer.Terapia = newPlayer.PlayerClass.Terapia;
        newPlayer.Sanidade = newPlayer.PlayerClass.Sanidade;
        newPlayer.Vigilancia = newPlayer.PlayerClass.Vigilancia;
        
        UpdateUI();

    }

    void UpdateUI()
    {
        atletismoText.text = newPlayer.Atletismo.ToString();
        pilotagemText.text = newPlayer.Pilotagem.ToString();
        roubarText.text = newPlayer.Roubar.ToString();
        saudeText.text = newPlayer.Saude.ToString();
        infiltracaoText.text = newPlayer.Infiltracao.ToString();

        mecanicaText.text = newPlayer.Mecanica.ToString();
        medicoText.text = newPlayer.Medico.ToString();
        preparoText.text = newPlayer.Preparo.ToString();
        lutaText.text = newPlayer.Luta.ToString();
        atirarText.text = newPlayer.Atirar.ToString();

        terapiaText.text = newPlayer.Terapia.ToString();
        sanidadeText.text = newPlayer.Sanidade.ToString();
        vigilanciaText.text = newPlayer.Vigilancia.ToString();
        pointsText.text = pointsToSpend.ToString();
    }

    public void SetAtletismo(int amount)
    {
        if(newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Atletismo += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Atletismo > newPlayer.PlayerClass.Atletismo)
            {
                newPlayer.Atletismo += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }
    public void SetPilotagem(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Pilotagem += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Pilotagem > newPlayer.PlayerClass.Pilotagem)
            {
                newPlayer.Pilotagem += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }
    public void SetRoubar(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Roubar += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Roubar > newPlayer.PlayerClass.Roubar)
            {
                newPlayer.Roubar += amount;
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
    public void SetInfiltracao(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Infiltracao += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Infiltracao > newPlayer.PlayerClass.Infiltracao)
            {
                newPlayer.Infiltracao += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }
    public void SetMecanica(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Mecanica += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Mecanica > newPlayer.PlayerClass.Mecanica)
            {
                newPlayer.Mecanica += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }
    public void SetMedico(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Preparo += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Preparo > newPlayer.PlayerClass.Preparo)
            {
                newPlayer.Preparo += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }
    public void SetLuta(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Luta += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Luta > newPlayer.PlayerClass.Luta)
            {
                newPlayer.Luta += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }
    public void SetAtirar(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Atirar += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Atirar > newPlayer.PlayerClass.Atirar)
            {
                newPlayer.Atirar += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }
    public void SetTerapia(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Terapia += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Terapia > newPlayer.PlayerClass.Terapia)
            {
                newPlayer.Terapia += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }
    public void SetSanidade(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Sanidade += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Sanidade > newPlayer.PlayerClass.Sanidade)
            {
                newPlayer.Sanidade += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }
    public void SetVigilancia(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Vigilancia += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Vigilancia > newPlayer.PlayerClass.Vigilancia)
            {
                newPlayer.Vigilancia += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }
    public void SetPreparo(int amount)
    {
        if (newPlayer.PlayerClass != null)
        {
            if (amount > 0 && pointsToSpend > 0)
            {
                newPlayer.Preparo += amount;
                pointsToSpend -= 1;
                UpdateUI();
            }
            else if (amount < 0 && newPlayer.Preparo > newPlayer.PlayerClass.Preparo)
            {
                newPlayer.Preparo += amount;
                pointsToSpend += 1;
                UpdateUI();
            }
        }
        else
        {
            Debug.Log("Nenhuma classe escolhida");
        }
    }

}
