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
        //--------------> BAÞLANGIÇ <---------- //
        if (!OyunBasladi)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                yazi.text=("Harika..Aklýndan 1-100 arasý bir sayý tut ve ENTER'a bas. ");
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
            //------------> BAÞLANGIÇ <-------- //
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
                yazi.text=("Yaþasýn... Aklýndaki sayýyý buldum !!! ");
                OyunBitti = true;
            }
        }
    }
    void Kontrol()
    {
        tahmin = (minSayi + maxSayi) / 2;
        yazi.text=("Aklýndan tuttuðun sayý " + tahmin +  " mi ? Daha büyük ise yukarý, daha küçük ise aþaðý yön tuþuna bas. Doðruysa boþluk'a bas !!");
    }

}
