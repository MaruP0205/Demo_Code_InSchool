using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public Text moneyText;
	public static int moneyAmount;
	int isBombSold;
    int isMumSold;
    int isBirdSold;
	public GameObject bomb;
    public GameObject mum;
     public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
		isBombSold = PlayerPrefs.GetInt("isBombSold");
        isMumSold = PlayerPrefs.GetInt("isMumSold");
        isBirdSold = PlayerPrefs.GetInt("isBirdSold");
		if (isBombSold == 1||isMumSold == 1 ||isBirdSold==1){
			bomb.SetActive (true);
            mum.SetActive (true);
            bird.SetActive (true);
        }
        else if(isBombSold != 1 ||isMumSold == 1||isBirdSold==1){
            bomb.SetActive (false);
            mum.SetActive (true);
            bird.SetActive (true);
        }
        else if(isBombSold != 1 ||isMumSold != 1||isBirdSold==1){
            bomb.SetActive (false);
            mum.SetActive (false);
            bird.SetActive (true);
        }
        else if(isBombSold == 1 ||isMumSold != 1||isBirdSold==1){
            bomb.SetActive (true);
            mum.SetActive (false);
            bird.SetActive (true);
        }
        else if(isBombSold == 1 ||isMumSold != 1||isBirdSold!=1){
            bomb.SetActive (true);
            mum.SetActive (false);
            bird.SetActive (false);
        }
        else if(isBombSold == 1 ||isMumSold == 1||isBirdSold!=1){
            bomb.SetActive (true);
            mum.SetActive (true);
            bird.SetActive (false);
        }
		else{
			bomb.SetActive (false);
            mum.SetActive (false);
            bird.SetActive (false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "Money: " + moneyAmount.ToString() + "$";
    }
    public void gotoShop()
	{
		PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
		SceneManager.LoadScene("Shop");
	} 
}
