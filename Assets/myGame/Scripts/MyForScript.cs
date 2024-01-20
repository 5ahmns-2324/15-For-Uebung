using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyForScript : MonoBehaviour
{
    int zeilenAnzahl = 3;
    int aktuelleZeile;

    void Start()
    {
        for (int zeile = 1; zeile <= zeilenAnzahl; zeile++)
        {
            string ausgabe = "";
            aktuelleZeile = zeile;

            ausgabe = GeneriereMinuszeichen(ausgabe);
            aktuelleZeile = zeile;

            for (int sterne = 1; sterne <= 2 * zeile - 1; sterne++)
            {
                ausgabe += "*";
            }

            ausgabe = GeneriereMinuszeichen(ausgabe);
            aktuelleZeile = zeile;

            Debug.Log(ausgabe);
        }
    }

    public string GeneriereMinuszeichen(string ausgabe)
    {
        for(int minuszeichen = 1; minuszeichen <= zeilenAnzahl-aktuelleZeile; minuszeichen ++ )
        {
            ausgabe += "-";
            
        }
        return ausgabe;
    }

}
