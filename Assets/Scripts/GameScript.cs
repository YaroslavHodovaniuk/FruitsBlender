using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 spawnPosotionCharacters = new Vector3(144.517f, 0, -0.24f);
    private Vector3 spawnPosotion = new Vector3(145.076f, 3.5f, 1.596f);
    private Quaternion standartRotation = new Quaternion(0, 0, 0, 0);

    private Color coctailColor = new Color(0, 0, 0);
    private Color greenAppleColor = new Color(0, 64, 0);
    private Color orangeColor = new Color(64, 32, 0);
    private Color eggplantColor = new Color(64, 0, 64);
    private Color tomatoColor = new Color(64, 0, 0);
    private Color cherryColor = new Color(64, 0, 0);
    private Color cucumberColor = new Color(0, 64, 0);
    private Color bananaColor = new Color(64, 64, 0);

    private Color lvlOneColor = new Color(64, 128, 0, 3);
    private Color lvlTwoColor = new Color(128, 96, 0, 4);
    private Color lvlThreeColor = new Color(128, 64, 64, 4);

    private bool lvlOneSwitch = true;
    private bool lvlTwoSwitch = false;
    private bool lvlThreeSwitch = false;

    private GameObject[] greenAppleClone = new GameObject[120];
    private GameObject[] eggplantClone = new GameObject[120];
    private GameObject[] tomatoClone = new GameObject[120];
    private GameObject[] cucumberClone = new GameObject[120];
    private GameObject[] cherryClone = new GameObject[120];
    private GameObject[] orangeClone = new GameObject[120];
    private GameObject[] bananaClone = new GameObject[120];

    private int greenAppleCloneCounter = 1;
    private int eggplantCloneCounter = 1;
    private int tomatoCloneCounter = 1;
    private int cucumberCloneCounter = 1;
    private int cherryCloneCounter = 1;
    private int orangeCloneCounter = 1;
    private int bananaCloneCounter = 1;

    public GameObject greenApplePrefab;
    public GameObject eggplantPrefab;
    public GameObject tomatoPrefab;
    public GameObject cucumberPrefab;
    public GameObject cherryPrefab;
    public GameObject orangePrefab;
    public GameObject bananaPrefab;

    public GameObject lvlOneCharacterPrefab;
    public GameObject lvlOneMessengeCloudPrefab;
    public GameObject lvlTwoCharacterPrefab;
    public GameObject lvlTwoMessengeCloudPrefab;
    public GameObject lvlThreeCharacterPrefab;
    public GameObject lvlThreeMessengeCloudPrefab;

    private GameObject lvlOneCharacterClone;
    private GameObject lvlOneMessengeCloudClone;
    private GameObject lvlTwoCharacterClone;
    private GameObject lvlTwoMessengeCloudClone;
    private GameObject lvlThreeCharacterClone;
    private GameObject lvlThreeMessengeCloudClone;

    private Color LoselvlOneColor;
    private Color LoselvlTwoColor;
    private Color LoselvlThreeColor;

    void Start()
    {
        lvlOneCharacterClone = Instantiate(lvlOneCharacterPrefab, spawnPosotionCharacters, standartRotation);
        lvlOneMessengeCloudClone = Instantiate(lvlOneMessengeCloudPrefab);
    }

   public void AddGreenApple()
    {
        Debug.Log("GreenApple");
        greenAppleClone[greenAppleCloneCounter] = Instantiate(greenApplePrefab, spawnPosotion, standartRotation);
        greenAppleCloneCounter++;
        coctailColor += greenAppleColor;
        
    }
    public void AddEggplant()
    {
        Debug.Log("Eggplant");
        eggplantClone[eggplantCloneCounter] = Instantiate(eggplantPrefab, spawnPosotion, standartRotation);
        eggplantCloneCounter++;
        coctailColor += eggplantColor;
    }
    public void AddTomato()
    {
        Debug.Log("Tomato");
        tomatoClone[tomatoCloneCounter] = Instantiate(tomatoPrefab, spawnPosotion, standartRotation);
        tomatoCloneCounter++;
        coctailColor += tomatoColor;
    }
    public void AddCucumber()
    {
        Debug.Log("Cucumber");
        cucumberClone[cucumberCloneCounter] = Instantiate(cucumberPrefab, spawnPosotion, standartRotation);
        cucumberCloneCounter++;
        coctailColor += cucumberColor;
    }
    public void AddCherry()
    {
        Debug.Log("Cherry");
        cherryClone[cherryCloneCounter] = Instantiate(cherryPrefab, spawnPosotion, standartRotation);
        cherryCloneCounter++;
        coctailColor += cherryColor;
    }
    public void AddOrange()
    {
        Debug.Log("Orange");
        orangeClone[orangeCloneCounter] = Instantiate(orangePrefab, spawnPosotion, standartRotation);
        orangeCloneCounter++;
        coctailColor += orangeColor;
    }
    public void AddBanana()
    {
        Debug.Log("Banana");
        bananaClone[bananaCloneCounter] = Instantiate(bananaPrefab, spawnPosotion, standartRotation);
        bananaCloneCounter++;
        coctailColor += bananaColor;
    }
    private void DeleteAllCloneFruits()
    {
        for (; greenAppleCloneCounter >= 0; greenAppleCloneCounter--)
        {
            Destroy(greenAppleClone[greenAppleCloneCounter]);
        }
        for (; eggplantCloneCounter >= 0; eggplantCloneCounter--)
        {
            Destroy(eggplantClone[eggplantCloneCounter]);
        }
        for (; tomatoCloneCounter >= 0; tomatoCloneCounter--)
        {
            Destroy(tomatoClone[tomatoCloneCounter]);
        }
        for (; cucumberCloneCounter >= 0; cucumberCloneCounter--)
        {
            Destroy(cucumberClone[cucumberCloneCounter]);
        }
        for (; cherryCloneCounter >= 0; cherryCloneCounter--)
        {
            Destroy(cherryClone[cherryCloneCounter]);
        }
        for (; orangeCloneCounter >= 0; orangeCloneCounter--)
        {
            Destroy(orangeClone[orangeCloneCounter]);
        }
        for (; bananaCloneCounter >= 0; bananaCloneCounter--)
        {
            Destroy(bananaClone[bananaCloneCounter]);
        }
        greenAppleCloneCounter = 1;
        eggplantCloneCounter = 1;
        tomatoCloneCounter = 1;
        cucumberCloneCounter = 1;
        cherryCloneCounter = 1;
        orangeCloneCounter = 1;
        bananaCloneCounter = 1;
}
    public void Mix()
    {
        Debug.Log("Mix");
        while (lvlThreeSwitch)
        {
            //check for 90 % similarity
            if ((coctailColor.r >= lvlThreeColor.r * 0.95 && coctailColor.r <= lvlThreeColor.r * 1.05) && (coctailColor.g >= lvlThreeColor.g * 0.95 && coctailColor.g <= lvlThreeColor.g * 1.05) && (coctailColor.b >= lvlThreeColor.b * 0.95 && coctailColor.b <= lvlThreeColor.b * 1.05))
            {
                Debug.Log("LvlThree win 90% similarity");
                coctailColor = new Color(0, 0, 0);
                lvlThreeSwitch = false;
                lvlOneSwitch = true;
                DeleteAllCloneFruits();
                Destroy(lvlThreeMessengeCloudClone);
                Destroy(lvlThreeCharacterClone);
                lvlOneCharacterClone = Instantiate(lvlOneCharacterPrefab);
                lvlOneMessengeCloudClone = Instantiate(lvlOneMessengeCloudPrefab);
            }
            else
            {
                Debug.Log("LvlThree Lose " + ((lvlThreeColor.r / coctailColor.r) + (lvlThreeColor.g / coctailColor.g) + (lvlThreeColor.b / coctailColor.b)) / 3 * 100 + " % miss");
                coctailColor = new Color(0, 0, 0);
                DeleteAllCloneFruits();
                break;
            }
        }
        while (lvlTwoSwitch)
        {
            //check for 90 % similarity
            if (coctailColor.r >= lvlTwoColor.r * 0.95 && coctailColor.r <= lvlTwoColor.r * 1.05 && coctailColor.g >= lvlTwoColor.g * 0.95 && coctailColor.g <= lvlTwoColor.g * 1.05)
            {
                Debug.Log("LvlTwo win 90% similarity");
                coctailColor = new Color(0, 0, 0);
                lvlThreeSwitch = true;
                lvlTwoSwitch = false;
                DeleteAllCloneFruits();
                Destroy(lvlTwoMessengeCloudClone);
                Destroy(lvlTwoCharacterClone);
                lvlThreeMessengeCloudClone = Instantiate(lvlThreeCharacterPrefab);
                lvlThreeCharacterClone = Instantiate(lvlThreeMessengeCloudPrefab);
            }
            else
            {
                Debug.Log("LvlTwo Lose " + ((lvlTwoColor.r / coctailColor.r) + (lvlTwoColor.g / coctailColor.g)) / 3 * 100 + " % miss");
                coctailColor = new Color(0, 0, 0);
                DeleteAllCloneFruits();
                break;
            }
        }
        while (lvlOneSwitch)
        {
            //check for 90 % similarity
            if (coctailColor.r >= lvlOneColor.r * 0.95 && coctailColor.r <= lvlOneColor.r * 1.05 && coctailColor.g >= lvlOneColor.g * 0.95 && coctailColor.g <= lvlOneColor.g * 1.05)
            {
                Debug.Log("LvlOne win 90% similarity");
                coctailColor = new Color(0, 0, 0);
                lvlTwoSwitch = true;
                lvlOneSwitch = false;
                DeleteAllCloneFruits();
                Destroy(lvlOneMessengeCloudClone);
                Destroy(lvlOneCharacterClone);
                lvlTwoCharacterClone = Instantiate(lvlTwoCharacterPrefab);
                lvlTwoMessengeCloudClone = Instantiate(lvlTwoMessengeCloudPrefab);

            }
            else
            {
                Debug.Log("LvlOne Lose " + (((lvlOneColor.r / coctailColor.r) + (lvlOneColor.g / coctailColor.g))) / 3 * 100 + " % miss");
                coctailColor = new Color(0, 0, 0);
                DeleteAllCloneFruits();
                break;
            }
        }
    }
}
