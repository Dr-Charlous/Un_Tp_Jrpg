using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUi : MonoBehaviour
{
    public Image ImagePortrait;
    public TMPro.TextMeshProUGUI TextLife;

    public void SetCharacter(Character character)
    {
        ImagePortrait.sprite = character.SpritePortrait;
        TextLife.text = character.Life.ToString();
    }
}