using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AbilityCooldown : MonoBehaviour
{

    public int coolDownTimerC, coolDownTimerRD, coolDownTimerRT, coolDownTimerMM;

    public bool Confirmed;

    public TMPro.TextMeshProUGUI countDownChange, countdownRDrink, countdownRTeleport, countdownMMagic;

    void Start()
    {
        coolDownTimerC = -1;
        coolDownTimerRD = -1;
        coolDownTimerRT = -1;
        coolDownTimerMM = -1;
        countDownChange.text = "";
        countdownRDrink.text = "";
        countdownRTeleport.text = "";
        countdownMMagic.text = "";

    }

    public void CooldownChange()
    {
        coolDownTimerC = 10;
        StartCoroutine(CountDown());

        IEnumerator CountDown()
        {
            while (coolDownTimerC > -1)
            {
                countDownChange.text = coolDownTimerC.ToString();

                yield return new WaitForSeconds(1f);

                coolDownTimerC--;
            }

            countDownChange.text = "";

            if (coolDownTimerC == 0)
            {
                countDownChange.text = "";
            }

        }
    }

public void CooldownRDrink()
    {
        coolDownTimerRD = 20;
        StartCoroutine(CountDownRD());

        IEnumerator CountDownRD()
        {
            while (coolDownTimerRD > -1)
            {
                countdownRDrink.text = coolDownTimerRD.ToString();

                yield return new WaitForSeconds(1f);

                coolDownTimerRD--;
            }

            countdownRDrink.text = "";

            if (coolDownTimerRD == 0)
            {
                countdownRDrink.text = "";
            }

        }
    }

    public void CooldownRTeleport()
    {
        coolDownTimerRT = 20;
        StartCoroutine(CountDownRT());

        IEnumerator CountDownRT()
        {
            while (coolDownTimerRT > -1)
            {
                countdownRTeleport.text = coolDownTimerRT.ToString();

                yield return new WaitForSeconds(1f);

                coolDownTimerRT--;
            }

            countdownRTeleport.text = "";

            if (coolDownTimerRT == 0)
            {
                countdownRTeleport.text = "";
            }

        }
    }

    public void CooldownMMagic()
    {
        coolDownTimerMM = 10;
        StartCoroutine(CountDownMM());

        IEnumerator CountDownMM()
        {
            while (coolDownTimerMM > -1)
            {
                countdownMMagic.text = coolDownTimerMM.ToString();

                yield return new WaitForSeconds(1f);

                coolDownTimerMM--;
            }

            countdownMMagic.text = "";

            if (coolDownTimerMM == 0)
            {
                countdownMMagic.text = "";
            }

        }
    }

}
