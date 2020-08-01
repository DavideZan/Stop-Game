using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorScript : MonoBehaviour
{
    public GameObject Zanna;
    public GameObject Arni;
    public GameObject Broccoli;
    public GameObject Costi;
    public GameObject Fede;
    public GameObject Fillo;
    public GameObject GiuliaB;
    public GameObject GiuliaD;
    public GameObject Greg;
    public GameObject Lucia;
    public GameObject Manu;
    public GameObject NicoA;
    public GameObject NicoAATM;
    private Vector3 CharacterPosition;
    private Vector3 OffScreen;
    private int CharacterInt = 1;
    public int ChosenCharacter { get => CharacterInt;}
    private SpriteRenderer ArniRender, ZannaRender, NicoAATMRender, NicoARender, ManuRender, LuciaRender, GregRender, GiuliaDRender, GiuliaBRender, FilloRender, FedeRender, CostiRender, BroccoliRender;

    private void Awake()
    {
        CharacterPosition = Zanna.transform.position;
        OffScreen = Arni.transform.position;
        ZannaRender = Zanna.GetComponent<SpriteRenderer>();
        ArniRender = Zanna.GetComponent<SpriteRenderer>();
        NicoAATMRender = Zanna.GetComponent<SpriteRenderer>();
        NicoARender = Zanna.GetComponent<SpriteRenderer>();
        ManuRender = Zanna.GetComponent<SpriteRenderer>();
        LuciaRender = Zanna.GetComponent<SpriteRenderer>();
        GregRender = Zanna.GetComponent<SpriteRenderer>();
        GiuliaDRender = Zanna.GetComponent<SpriteRenderer>();
        GiuliaBRender = Zanna.GetComponent<SpriteRenderer>();
        FilloRender = Zanna.GetComponent<SpriteRenderer>();
        FedeRender = Zanna.GetComponent<SpriteRenderer>();
        CostiRender = Zanna.GetComponent<SpriteRenderer>();
        BroccoliRender = Zanna.GetComponent<SpriteRenderer>();


    }
     public void NextCharacter()
    {
        switch(CharacterInt)
        {
            case 1:
                ZannaRender.enabled = false;
                Zanna.transform.position = OffScreen;
                Arni.transform.position = CharacterPosition;
                ArniRender.enabled = true;
                CharacterInt++;
                break;
            case 2:
                ArniRender.enabled = false;
                Arni.transform.position = OffScreen;
                NicoAATM.transform.position = CharacterPosition;
                NicoAATMRender.enabled = true;
                CharacterInt++;
                break;
            case 3:
                NicoAATMRender.enabled = false;
                NicoAATM.transform.position = OffScreen;
                NicoA.transform.position = CharacterPosition;
                NicoARender.enabled = true;
                CharacterInt++;
                break;
            case 4:
                NicoARender.enabled = false;
                NicoA.transform.position = OffScreen;
                Manu.transform.position = CharacterPosition;
                ManuRender.enabled = true;
                CharacterInt++;
                break;
            case 5:
                ManuRender.enabled = false;
                Manu.transform.position = OffScreen;
                Lucia.transform.position = CharacterPosition;
                LuciaRender.enabled = true;
                CharacterInt++;
                break;
            case 6:
                LuciaRender.enabled = false;
                Lucia.transform.position = OffScreen;
                Greg.transform.position = CharacterPosition;
                GregRender.enabled = true;
                CharacterInt++;
                break;
            case 7:
                GregRender.enabled = false;
                Greg.transform.position = OffScreen;
                GiuliaD.transform.position = CharacterPosition;
                GiuliaDRender.enabled = true;
                CharacterInt++;
                break;
            case 8:
                GiuliaDRender.enabled = false;
                GiuliaD.transform.position = OffScreen;
                GiuliaB.transform.position = CharacterPosition;
                GiuliaBRender.enabled = true;
                CharacterInt++;
                break;
            case 9:
                GiuliaBRender.enabled = false;
                GiuliaB.transform.position = OffScreen;
                Fillo.transform.position = CharacterPosition;
                FilloRender.enabled = true;
                CharacterInt++;
                break;
            case 10:
                FilloRender.enabled = false;
                Fillo.transform.position = OffScreen;
                Fede.transform.position = CharacterPosition;
                FedeRender.enabled = true;
                CharacterInt++;
                break;
            case 11:
                FedeRender.enabled = false;
                Fede.transform.position = OffScreen;
                Costi.transform.position = CharacterPosition;
                CostiRender.enabled = true;
                CharacterInt++;
                break;
            case 12:
                CostiRender.enabled = false;
                Costi.transform.position = OffScreen;
                Broccoli.transform.position = CharacterPosition;
                BroccoliRender.enabled = true;
                CharacterInt++;
                break;
            case 13:
                BroccoliRender.enabled = false;
                Broccoli.transform.position = OffScreen;
                Zanna.transform.position = CharacterPosition;
                ZannaRender.enabled = true;
                CharacterInt++;
                ResetInt();
                break;
            default:
                ResetInt();
                break;

        }

    }
    public void PreviousCharacter()
    {
        switch (CharacterInt)
        {
            case 1:
                ZannaRender.enabled = false;
                Zanna.transform.position = OffScreen;
                Broccoli.transform.position = CharacterPosition;
                BroccoliRender.enabled = true;
                CharacterInt--;
                ResetInt();
                break;
            case 2:
                ArniRender.enabled = false;
                Arni.transform.position = OffScreen;
                Zanna.transform.position = CharacterPosition;
                ZannaRender.enabled = true;
                CharacterInt--;
                break;
            case 3:
                NicoAATMRender.enabled = false;
                NicoAATM.transform.position = OffScreen;
                Arni.transform.position = CharacterPosition;
                ArniRender.enabled = true;
                CharacterInt--;
                break;
            case 4:
                NicoARender.enabled = false;
                NicoA.transform.position = OffScreen;
                NicoAATM.transform.position = CharacterPosition;
                NicoAATMRender.enabled = true;
                CharacterInt--;
                break;
            case 5:
                ManuRender.enabled = false;
                Manu.transform.position = OffScreen;
                NicoA.transform.position = CharacterPosition;
                NicoARender.enabled = true;
                CharacterInt--;
                break;
            case 6:
                LuciaRender.enabled = false;
                Lucia.transform.position = OffScreen;
                Manu.transform.position = CharacterPosition;
                ManuRender.enabled = true;
                CharacterInt--;
                break;
            case 7:
                GregRender.enabled = false;
                Greg.transform.position = OffScreen;
                Lucia.transform.position = CharacterPosition;
                LuciaRender.enabled = true;
                CharacterInt--;
                break;
            case 8:
                GiuliaDRender.enabled = false;
                GiuliaD.transform.position = OffScreen;
                Greg.transform.position = CharacterPosition;
                GregRender.enabled = true;
                CharacterInt--;
                break;
            case 9:
                GiuliaBRender.enabled = false;
                GiuliaB.transform.position = OffScreen;
                GiuliaD.transform.position = CharacterPosition;
                GiuliaDRender.enabled = true;
                CharacterInt--;
                break;
            case 10:
                FilloRender.enabled = false;
                Fillo.transform.position = OffScreen;
                GiuliaB.transform.position = CharacterPosition;
                GiuliaBRender.enabled = true;
                CharacterInt--;
                break;
            case 11:
                FedeRender.enabled = false;
                Fede.transform.position = OffScreen;
                Fillo.transform.position = CharacterPosition;
                FilloRender.enabled = true;
                CharacterInt--;
                break;
            case 12:
                CostiRender.enabled = false;
                Costi.transform.position = OffScreen;
                Fede.transform.position = CharacterPosition;
                FedeRender.enabled = true;
                CharacterInt--;
                break;
            case 13:
                BroccoliRender.enabled = false;
                Broccoli.transform.position = OffScreen;
                Costi.transform.position = CharacterPosition;
                CostiRender.enabled = true;
                CharacterInt--;
                break;
            default:
                ResetInt();
                break;

        }
    }
    private void ResetInt()
    {
        if(CharacterInt >= 13)
        {
            CharacterInt = 1;
        }
        else
        {
            CharacterInt = 4;
        }
    }
}
