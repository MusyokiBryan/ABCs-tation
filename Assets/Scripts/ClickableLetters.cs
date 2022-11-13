using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;



public class ClickableLetters : MonoBehaviour, IPointerClickHandler
{
    char _randomLetter;
    bool upperCase;
    public void OnPointerClick(PointerEventData eventData)
    {

        // Debug.Log($"Clicked on letter {_randomLetter}");
        if (_randomLetter == GameController.Instance.Letter)
        {
            GetComponent<TMP_Text>().color = Color.green;
            enabled = false;
            GameController.Instance.HandleCorrectLetterClick(upperCase);        
        }
        else
        {
            GetComponent<TMP_Text>().color = Color.red;
        }
    }

   internal void SetLetter(char letter)
    {
        enabled = true;
        GetComponent<TMP_Text>().color = Color.blue;
        _randomLetter = letter;

        if (Random.Range(0, 100) > 50)
        {
            upperCase = false;
            GetComponent<TMP_Text>().text = _randomLetter.ToString();
        }
        else
        {
            upperCase = true;
            GetComponent<TMP_Text>().text = _randomLetter.ToString().ToUpper();
        }
    }
}
