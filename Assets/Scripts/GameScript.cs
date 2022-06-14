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

    private Color _coctailColor = new Color(0, 0, 0);
    private Color _greenAppleColor = new Color(0, 64, 0);
    private Color _orangeColor = new Color(64, 32, 0);
    private Color _eggplantColor = new Color(64, 0, 64);
    private Color _tomatoColor = new Color(64, 0, 0);
    private Color _cherryColor = new Color(64, 0, 0);
    private Color _cucumberColor = new Color(0, 64, 0);
    private Color _bananaColor = new Color(64, 64, 0);

    private Color _lvlOneColor = new Color(64, 128, 0, 3);
    private Color _lvlTwoColor = new Color(128, 96, 0, 4);
    private Color _lvlThreeColor = new Color(128, 64, 64, 4);

    private bool _lvlOneSwitch = true;
    private bool _lvlTwoSwitch = false;
    private bool _lvlThreeSwitch = false;

    private GameObject[] _greenAppleClone = new GameObject[120];
    private GameObject[] _eggplantClone = new GameObject[120];
    private GameObject[] _tomatoClone = new GameObject[120];
    private GameObject[] _cucumberClone = new GameObject[120];
    private GameObject[] _cherryClone = new GameObject[120];
    private GameObject[] _orangeClone = new GameObject[120];
    private GameObject[] _bananaClone = new GameObject[120];

    private int _greenAppleCloneCounter = 1;
    private int _eggplantCloneCounter = 1;
    private int _tomatoCloneCounter = 1;
    private int _cucumberCloneCounter = 1;
    private int _cherryCloneCounter = 1;
    private int _orangeCloneCounter = 1;
    private int _bananaCloneCounter = 1;

    [SerializeField] private GameObject GreenApplePrefab;
    [SerializeField] private GameObject EggplantPrefab;
    [SerializeField] private GameObject TomatoPrefab;
    [SerializeField] private GameObject CucumberPrefab;
    [SerializeField] private GameObject CherryPrefab;
    [SerializeField] private GameObject OrangePrefab;
    [SerializeField] private GameObject BananaPrefab;

    [SerializeField] private GameObject LvlOneCharacterPrefab;
    [SerializeField] private GameObject LvlOneMessengeCloudPrefab;
    [SerializeField] private GameObject LvlTwoCharacterPrefab;
    [SerializeField] private GameObject LvlTwoMessengeCloudPrefab;
    [SerializeField] private GameObject LvlThreeCharacterPrefab;
    [SerializeField] private GameObject LvlThreeMessengeCloudPrefab;

    private GameObject _lvlOneCharacterClone;
    private GameObject _lvlOneMessengeCloudClone;
    private GameObject _lvlTwoCharacterClone;
    private GameObject _lvlTwoMessengeCloudClone;
    private GameObject _lvlThreeCharacterClone;
    private GameObject _lvlThreeMessengeCloudClone;

    private Color _LoselvlOneColor;
    private Color _LoselvlTwoColor;
    private Color _LoselvlThreeColor;

    void Start()
    {
        _lvlOneCharacterClone = Instantiate(LvlOneCharacterPrefab, spawnPosotionCharacters, standartRotation);
        _lvlOneMessengeCloudClone = Instantiate(LvlOneMessengeCloudPrefab);
    }

   public void AddGreenApple()
    {
        Debug.Log("GreenApple");
        _greenAppleClone[_greenAppleCloneCounter] = Instantiate(GreenApplePrefab, spawnPosotion, standartRotation);
        _greenAppleCloneCounter++;
        _coctailColor += _greenAppleColor;
        
    }
    public void AddEggplant()
    {
        Debug.Log("Eggplant");
        _eggplantClone[_eggplantCloneCounter] = Instantiate(EggplantPrefab, spawnPosotion, standartRotation);
        _eggplantCloneCounter++;
        _coctailColor += _eggplantColor;
    }
    public void AddTomato()
    {
        Debug.Log("Tomato");
        _tomatoClone[_tomatoCloneCounter] = Instantiate(TomatoPrefab, spawnPosotion, standartRotation);
        _tomatoCloneCounter++;
        _coctailColor += _tomatoColor;
    }
    public void AddCucumber()
    {
        Debug.Log("Cucumber");
        _cucumberClone[_cucumberCloneCounter] = Instantiate(CucumberPrefab, spawnPosotion, standartRotation);
        _cucumberCloneCounter++;
        _coctailColor += _cucumberColor;
    }
    public void AddCherry()
    {
        Debug.Log("Cherry");
        _cherryClone[_cherryCloneCounter] = Instantiate(CherryPrefab, spawnPosotion, standartRotation);
        _cherryCloneCounter++;
        _coctailColor += _cherryColor;
    }
    public void AddOrange()
    {
        Debug.Log("Orange");
        _orangeClone[_orangeCloneCounter] = Instantiate(OrangePrefab, spawnPosotion, standartRotation);
        _orangeCloneCounter++;
        _coctailColor += _orangeColor;
    }
    public void AddBanana()
    {
        Debug.Log("Banana");
        _bananaClone[_bananaCloneCounter] = Instantiate(BananaPrefab, spawnPosotion, standartRotation);
        _bananaCloneCounter++;
        _coctailColor += _bananaColor;
    }
    private void DeleteAllCloneFruits()
    {
        for (; _greenAppleCloneCounter >= 0; _greenAppleCloneCounter--)
        {
            Destroy(_greenAppleClone[_greenAppleCloneCounter]);
        }
        for (; _eggplantCloneCounter >= 0; _eggplantCloneCounter--)
        {
            Destroy(_eggplantClone[_eggplantCloneCounter]);
        }
        for (; _tomatoCloneCounter >= 0; _tomatoCloneCounter--)
        {
            Destroy(_tomatoClone[_tomatoCloneCounter]);
        }
        for (; _cucumberCloneCounter >= 0; _cucumberCloneCounter--)
        {
            Destroy(_cucumberClone[_cucumberCloneCounter]);
        }
        for (; _cherryCloneCounter >= 0; _cherryCloneCounter--)
        {
            Destroy(_cherryClone[_cherryCloneCounter]);
        }
        for (; _orangeCloneCounter >= 0; _orangeCloneCounter--)
        {
            Destroy(_orangeClone[_orangeCloneCounter]);
        }
        for (; _bananaCloneCounter >= 0; _bananaCloneCounter--)
        {
            Destroy(_bananaClone[_bananaCloneCounter]);
        }
        _greenAppleCloneCounter = 1;
        _eggplantCloneCounter = 1;
        _tomatoCloneCounter = 1;
        _cucumberCloneCounter = 1;
        _cherryCloneCounter = 1;
        _orangeCloneCounter = 1;
        _bananaCloneCounter = 1;
}
    public void Mix()
    {
        Debug.Log("Mix");
        while (_lvlThreeSwitch)
        {
            //check for 90 % similarity
            if ((_coctailColor.r >= _lvlThreeColor.r * 0.95 && _coctailColor.r <= _lvlThreeColor.r * 1.05) && (_coctailColor.g >= _lvlThreeColor.g * 0.95 && _coctailColor.g <= _lvlThreeColor.g * 1.05) && (_coctailColor.b >= _lvlThreeColor.b * 0.95 && _coctailColor.b <= _lvlThreeColor.b * 1.05))
            {
                Debug.Log("LvlThree win 90% similarity");
                _coctailColor = new Color(0, 0, 0);
                _lvlThreeSwitch = false;
                _lvlOneSwitch = true;
                DeleteAllCloneFruits();
                Destroy(_lvlThreeMessengeCloudClone);
                Destroy(_lvlThreeCharacterClone);
                _lvlOneCharacterClone = Instantiate(LvlOneCharacterPrefab);
                _lvlOneMessengeCloudClone = Instantiate(LvlOneMessengeCloudPrefab);
            }
            else
            {
                Debug.Log("LvlThree Lose " + ((_lvlThreeColor.r / _coctailColor.r) + (_lvlThreeColor.g / _coctailColor.g) + (_lvlThreeColor.b / _coctailColor.b)) / 3 * 100 + " % miss");
                _coctailColor = new Color(0, 0, 0);
                DeleteAllCloneFruits();
                break;
            }
        }
        while (_lvlTwoSwitch)
        {
            //check for 90 % similarity
            if (_coctailColor.r >= _lvlTwoColor.r * 0.95 && _coctailColor.r <= _lvlTwoColor.r * 1.05 && _coctailColor.g >= _lvlTwoColor.g * 0.95 && _coctailColor.g <= _lvlTwoColor.g * 1.05)
            {
                Debug.Log("LvlTwo win 90% similarity");
                _coctailColor = new Color(0, 0, 0);
                _lvlThreeSwitch = true;
                _lvlTwoSwitch = false;
                DeleteAllCloneFruits();
                Destroy(_lvlTwoMessengeCloudClone);
                Destroy(_lvlTwoCharacterClone);
                _lvlThreeMessengeCloudClone = Instantiate(LvlThreeCharacterPrefab);
                _lvlThreeCharacterClone = Instantiate(LvlThreeMessengeCloudPrefab);
            }
            else
            {
                Debug.Log("LvlTwo Lose " + ((_lvlTwoColor.r / _coctailColor.r) + (_lvlTwoColor.g / _coctailColor.g)) / 3 * 100 + " % miss");
                _coctailColor = new Color(0, 0, 0);
                DeleteAllCloneFruits();
                break;
            }
        }
        while (_lvlOneSwitch)
        {
            //check for 90 % similarity
            if (_coctailColor.r >= _lvlOneColor.r * 0.95 && _coctailColor.r <= _lvlOneColor.r * 1.05 && _coctailColor.g >= _lvlOneColor.g * 0.95 && _coctailColor.g <= _lvlOneColor.g * 1.05)
            {
                Debug.Log("LvlOne win 90% similarity");
                _coctailColor = new Color(0, 0, 0);
                _lvlTwoSwitch = true;
                _lvlOneSwitch = false;
                DeleteAllCloneFruits();
                Destroy(_lvlOneMessengeCloudClone);
                Destroy(_lvlOneCharacterClone);
                _lvlTwoCharacterClone = Instantiate(LvlTwoCharacterPrefab);
                _lvlTwoMessengeCloudClone = Instantiate(LvlTwoMessengeCloudPrefab);

            }
            else
            {
                Debug.Log("LvlOne Lose " + (((_lvlOneColor.r / _coctailColor.r) + (_lvlOneColor.g / _coctailColor.g))) / 3 * 100 + " % miss");
                _coctailColor = new Color(0, 0, 0);
                DeleteAllCloneFruits();
                break;
            }
        }
    }
}
