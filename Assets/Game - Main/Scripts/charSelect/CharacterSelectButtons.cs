using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectButtons : MonoBehaviour
{
    public CharacterSelectMain _CharacterSelectMain;

    public int CharacterNumber;
    public bool charNum;

    public Button RickNMorty, Summer, Jerry, Beth;

    // Start is called before the first frame update
    void Start()
    {
        charNum = false;
        CharacterNumber = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
           _CharacterSelectMain.Confirm(true);
        }

        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CharacterNumber --;
            charNum = false;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CharacterNumber ++;
            charNum = false;
        }


        if (CharacterNumber < 1)
        {
            CharacterNumber = 1;
            charNum = true;

            RickNMorty.interactable = false;
            Summer.interactable = true;
            Jerry.interactable = true;
            Beth.interactable = true;
        }
        else if (CharacterNumber > 4)
        {
            CharacterNumber = 4;
            charNum = true;

            Beth.interactable = false;
            Summer.interactable = true;
            RickNMorty.interactable = true;
            Jerry.interactable = true;
        }


        if ((CharacterNumber == 1) && (!charNum))
        {
            _CharacterSelectMain.charButtonRickNMorty(true);
            charNum = true;

            RickNMorty.interactable = false;
            Summer.interactable = true;
            Jerry.interactable = true;
            Beth.interactable = true;
        }
       else if ((CharacterNumber == 2) && (!charNum))
        {
            _CharacterSelectMain.charButtonSummer(true);
            charNum = true;

            Summer.interactable = false;
            RickNMorty.interactable = true;
            Jerry.interactable = true;
            Beth.interactable = true;
        }
       else if ((CharacterNumber == 3) && (!charNum))
        {
            _CharacterSelectMain.charButtonJerry(true);
            charNum = true;

            Jerry.interactable = false;
            Summer.interactable = true;
            RickNMorty.interactable = true;
            Beth.interactable = true;
        }
       else if ((CharacterNumber == 4) && (!charNum))
        {
            _CharacterSelectMain.charButtonBeth(true);
            charNum = true;

            Beth.interactable = false;
            Summer.interactable = true;
            RickNMorty.interactable = true;
            Jerry.interactable = true;
        }

    }
}
