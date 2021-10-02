using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class BattleSystem : MonoBehaviour
{

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    public BattleState state;

    Unit playerUnit;
    Unit enemyUnit;

    public Text dialogText;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;

    public Button attackBut;
    public Button healBut;
    void Start()
    {
        state = BattleState.START;
       StartCoroutine( SetupBattle());
    }

    IEnumerator SetupBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<Unit>();

        GameObject enemyGO = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemyGO.GetComponent<Unit>();

        dialogText.text = enemyUnit.unitName + " se aproxima para lutar";

        playerHUD.SetHUD(playerUnit);
        enemyHUD.SetHUD(enemyUnit);

        yield return new WaitForSeconds(2f);
        state = BattleState.PLAYERTURN;
        PlayerTurn();



    }

    IEnumerator PlayerAttack()
    {
        bool isDead = enemyUnit.TakeDamage(playerUnit.damage);
        enemyHUD.SetHP(enemyUnit.currentHP);
        dialogText.text = "Você acertou o ataque!";
        yield return new WaitForSeconds(2f);

        if (isDead)
        {
            state = BattleState.WON;
            EndBattle();
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
    }
    IEnumerator EnemyTurn()
    {
        dialogText.text = enemyUnit.unitName + " ataca!";

        yield return new WaitForSeconds(1f);

       bool isDead =  playerUnit.TakeDamage(enemyUnit.damage);

        playerHUD.SetHP(playerUnit.currentHP);

        yield return new WaitForSeconds(1f);

        if (isDead)
        {
            state = BattleState.LOST;
            EndBattle();
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        } 
    }
    void EndBattle()
    {
        if(state == BattleState.WON)
        {
            dialogText.text = "Você venceu!";
        }
        else if (state == BattleState.LOST)
        {
            dialogText.text = "Você falhou... nada deterá as bruxas...";
        }
    }
    void PlayerTurn()
    {
        attackBut.interactable = true;
        healBut.interactable = true;
        dialogText.text = "Escolha uma ação";
    }

    IEnumerator PlayerHeal()
    {
        playerUnit.Heal(5);

        playerHUD.SetHP(playerUnit.currentHP);
        dialogText.text = "Você recupera o fôlego";

        yield return new WaitForSeconds(2f);
        state = BattleState.ENEMYTURN;
        StartCoroutine(EnemyTurn());
    }

    public void OnAttackButton()
    {
        attackBut.interactable = false;
        healBut.interactable = false;
        if (state != BattleState.PLAYERTURN)
            return;

        StartCoroutine(PlayerAttack());
    }

   public void OnHealButton()
    {
        attackBut.interactable = false;
        healBut.interactable = false;
        if (state != BattleState.PLAYERTURN)
            return;

        StartCoroutine(PlayerHeal());
    }
}
