using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    [SerializeField] public GameObject gameOverBox;
    public EndGame endGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered Trigger");
            endGame.GetComponent<EndGame>().enabled = false;
            gameOverBox.SetActive(true);
            PlayerPrefs.SetFloat($"dificulty{Difficulty.difficulty + 1}", Difficulty.difficulty + 1);
           
            PlayerPrefs.Save();
            Invoke(nameof(HeyEnd),2f);


        }
    }

    public void HeyEnd()
    {
        Time.timeScale = 0;

    }
}