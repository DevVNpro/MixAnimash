using System;
using System.Collections;
using System.Collections.Generic;
using Projects.Script.Manager;
using Projects.Script.PvP.EnemyCard;
using Projects.Script.PvP.PlayerScript;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.PvP
{
    public class GameHandler : MonoBehaviour
    {
        [Header("WinAlert")] [SerializeField] private Image imageWin;
        [Header("WinAlert")] [SerializeField] private Image imageLose;

        [Header("DeckTeam")] [SerializeField] private RectTransform dectTeam;
        [Header("EnemyTeam")] [SerializeField] private RectTransform enemyTeam;

        [Header("ButtonWinLose")] [SerializeField] private GameObject buttonWinLose;

        [Header("TextBattle")] [SerializeField]  private GameObject textBattlePlayer;
        [SerializeField]  private GameObject textBattleEnemy;

        [Header("Background")]
        [SerializeField]
        private GameObject whiteTriangle;

        //playerWin
        [SerializeField]  private RectTransform backgroundEnemy;
        [SerializeField] private RectTransform bluePattern;
        //enemyWin
        [SerializeField] private RectTransform backgroundEnemyWin;
        [SerializeField] private RectTransform yellowPattern;

        bool endGame = false;


       
        private void Update()
        {
            if (!endGame)
            {
            if (TotalAttack.sumAttack == 0)
            {
                endGame = true;
                StartCoroutine(TurnOnLoseImg());
            }
            if (TotalAttackEnemy.sumAttack == 0)
            {
                endGame = true;
                StartCoroutine(TurnOnWinImg());
            }
            }
        }
        IEnumerator TurnOnWinImg()
        {
            yield return  new WaitForSeconds(3f);
            textBattlePlayer.SetActive(false);
            textBattleEnemy.SetActive(false);
            enemyTeam.gameObject.SetActive(false);
            dectTeam.gameObject.SetActive(false);
            whiteTriangle.SetActive(false);
            LeanTween.move(backgroundEnemy, new Vector3(backgroundEnemy.anchoredPosition.x, 0), 3f).setEaseLinear();
            LeanTween.move(bluePattern, new Vector3(bluePattern.anchoredPosition.x, 2000f), 1.5f);
            yield return  new WaitForSeconds(2.3f);
            buttonWinLose.LeanScale(new Vector3(1, 1), 3f).setEase(LeanTweenType.easeOutElastic);
            imageWin.transform.LeanScale(new Vector3(1, 1), 3f).setEase(LeanTweenType.easeOutElastic);
            yield return new WaitForSeconds(0.3f);
            SoundManager.Instance.PlayVfxMuSic("Win");
        }
        IEnumerator TurnOnLoseImg()
        {
            yield return  new WaitForSeconds(4f);
            textBattlePlayer.SetActive(false);
            textBattleEnemy.SetActive(false);
            dectTeam.gameObject.SetActive(false);
            enemyTeam.gameObject.SetActive(false);
            whiteTriangle.SetActive(false);
            LeanTween.move(backgroundEnemyWin, new Vector3(backgroundEnemyWin.anchoredPosition.x, 0), 2f);
            LeanTween.move(yellowPattern, new Vector3(yellowPattern.anchoredPosition.x, 2100f), 2f);
            yield return  new WaitForSeconds(2.3f);   
            buttonWinLose.LeanScale(new Vector3(1, 1), 3f).setEase(LeanTweenType.easeOutElastic);
            imageLose.transform.LeanScale(new Vector3(1, 1), 3f).setEase(LeanTweenType.easeOutElastic);
            yield return new WaitForSeconds(0.3f);
            SoundManager.Instance.PlayVfxMuSic("Lose");
        }




    }
}
