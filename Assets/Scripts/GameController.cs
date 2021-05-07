using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    [SerializeField] AudioClip _backgroundMusic;

    //Player Stats
    [SerializeField] int _smarts = 5;
    [SerializeField] Text _smartsText;
    [SerializeField] int _boldness = 4;
    [SerializeField] Text _boldnessText;
    [SerializeField] int _creativity = 6;
    [SerializeField] Text _creativityText;
    [SerializeField] int _charm = 4;
    [SerializeField] Text _charmText;
    [SerializeField] int _fun = 4;
    [SerializeField] Text _funText;
    [SerializeField] int _money = 8;
    [SerializeField] Text _moneyText;
    [SerializeField] DialogueManager _dialogueManager;
    

    // Start is called before the first frame update
    void Start()
    {
   
        UpdateStats();

        if(_backgroundMusic != null)
        {
            AudioManager.Instance.PlaySong(_backgroundMusic);
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateStats();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quitting Game...");
            QuitGame();
        }


        if (Input.GetKeyDown(KeyCode.Return))
        {
            _dialogueManager.DisplayNextSentence();
        }


    }


    void QuitGame()
    {
        Application.Quit();
    }


    void UpdateStats()
    {
        _smartsText.text = _smarts.ToString();
        _boldnessText.text = _boldness.ToString();
        _creativityText.text = _creativity.ToString();
        _charmText.text = _charm.ToString();
        _funText.text = _fun.ToString();
        _moneyText.text = _money.ToString();
    }

    public void ChangeCreativity(int value)
    {
        _creativity += value;
    }

    public void ChangeCharm(int value)
    {
        _charm += value;
    }


}
