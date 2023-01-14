using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitiesCooldownB : MonoBehaviour
{
    public int coolDownTimerBD, coolDownTimerBH, coolDownTimerBDa;

    public TMPro.TextMeshProUGUI countdownBDart, countdownBHeal, countdownBDash;
    void Start()
    {
        coolDownTimerBD = -1;
        countdownBDart.text = "";
        coolDownTimerBH = -1;
        countdownBHeal.text = "";
        coolDownTimerBDa = -1;
        countdownBDash.text = "";
    }

    public void CooldownBDart()
    {
        coolDownTimerBD = 10;
        StartCoroutine(CountDownBD());

        IEnumerator CountDownBD()
        {
            while (coolDownTimerBD > -1)
            {
                countdownBDart.text = coolDownTimerBD.ToString();

                yield return new WaitForSeconds(1f);

                coolDownTimerBD--;
            }

            countdownBDart.text = "";

            if (coolDownTimerBD == 0)
            {
                countdownBDart.text = "";
            }

        }
    }

    public void CooldownBHeal()
    {
        coolDownTimerBH = 15;
        StartCoroutine(CountDownBH());

        IEnumerator CountDownBH()
        {
            while (coolDownTimerBH > -1)
            {
                countdownBHeal.text = coolDownTimerBH.ToString();

                yield return new WaitForSeconds(1f);

                coolDownTimerBH--;
            }

            countdownBHeal.text = "";

            if (coolDownTimerBH == 0)
            {
                countdownBHeal.text = "";
            }

        }
    }

    public void CooldownBDash()
    {
        coolDownTimerBDa = 7;
        StartCoroutine(CountDownBDa());

        IEnumerator CountDownBDa()
        {
            while (coolDownTimerBDa > -1)
            {
                countdownBDash.text = coolDownTimerBDa.ToString();

                yield return new WaitForSeconds(1f);

                coolDownTimerBDa--;
            }

            countdownBDash.text = "";

            if (coolDownTimerBDa == 0)
            {
                countdownBDash.text = "";
            }

        }
    }
}
