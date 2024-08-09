using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerMessage;
    [SerializeField] private TMP_Text _adScore;
    [SerializeField] private GameObject _uiCardPanel;


    public int Score { get; set; }

    public void DisplayUICard()
    {
        _uiCardPanel.SetActive(true);
    }

    public void ShowPlayerMessage(string msg)
    {
        _playerMessage.text = msg;
        StartCoroutine(ClearPlayerMessage());
    }

    IEnumerator ClearPlayerMessage()
    {
        yield return new WaitForSeconds(11);
        _playerMessage.text = "";
    }

    public void UpdateScore()
    {
        _adScore.text = Score.ToString();
    }
}
