using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;
using Input = UnityEngine.Input;
using Random = UnityEngine.Random;


public class yaziDegistir : MonoBehaviour
{
 
    public Text yazi;
    public Text deger;



    int minSayi = 1;
    int maxSayi = 100;
    int tahmin;
    bool OyunBasladi = false;
    bool OyunBitti = false;
    // Start is called before the first frame update
    void Start()
    {
      yazi.text="Benimle oyun oynamak ister misin? (E/H) ";
    }
    // Update is called once per frame
    void Update()
    {
        //--------------> BA�LANGI� <---------- //
        if (!OyunBasladi)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                yazi.text=("Harika..Akl�ndan 1-100 aras� bir say� tut ve ENTER'a bas. ");
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                yazi.text=("Sen bilirsin .. ");
                new WaitForSeconds(3);
                Application.Quit();
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Kontrol();
                OyunBasladi = true;
            }
            //------------> BA�LANGI� <-------- //
        }
        else if (!OyunBitti)
        {

            //----------->OYUN KISMI<---------//
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minSayi = tahmin;
                Kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxSayi = tahmin;
                Kontrol();

            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                deger.text = tahmin.ToString();
                yazi.text=("Ya�as�n... Akl�ndaki say�y� buldum !!! ");
                OyunBitti = true;
            }
        }
    }
    void Kontrol()
    {
        tahmin = (minSayi + maxSayi) / 2;
        yazi.text=("Akl�ndan tuttu�un say� " + tahmin +  " mi ? Daha b�y�k ise yukar�, daha k���k ise a�a�� y�n tu�una bas. Do�ruysa bo�luk'a bas !!");
    }

}
