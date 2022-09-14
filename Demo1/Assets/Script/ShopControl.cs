using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControl : MonoBehaviour
{
    int moneyAmount;
	int isBombSold;
	int isMumSold;
	int isBirdSold;
	public Text moneyAmountText;
	public Text bombPrice;
	public Text MumPrice;
	public Text BirdPrice;
	public Button buyButton;
	public Button mumButton;
	public Button birdButton;
    // Start is called before the first frame update
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
    }

    // Update is called once per frame
    void Update()
    {
        moneyAmountText.text = "Money: " + moneyAmount.ToString() + "$";
		isBombSold = PlayerPrefs.GetInt("isBombSold");
		if (moneyAmount >= 10 && isBombSold == 0)
			buyButton.interactable = true;
		else
			buyButton.interactable = false;	

		if (moneyAmount >= 5 && isMumSold == 0)
			mumButton.interactable = true;
		else
			mumButton.interactable = false;	
		if (moneyAmount >= 5 && isMumSold == 0)
			birdButton.interactable = true;
		else
			birdButton.interactable = false;	
    }
    public void buyBomb()
	{
		moneyAmount -= 10;
		PlayerPrefs.SetInt("isBombSold", 1);
		bombPrice.text = "Sold!";
		buyButton.gameObject.SetActive (false);
	}
	public void buyMum()
	{
		moneyAmount -= 5;
		PlayerPrefs.SetInt("isMumSold", 1);
		MumPrice.text = "Sold!";
		mumButton.gameObject.SetActive (false);
	}
	public void buyBird()
	{
		moneyAmount -= 5;
		PlayerPrefs.SetInt("isBirdSold", 1);
		BirdPrice.text = "Sold!";
		birdButton.gameObject.SetActive (false);
	}
    public void exitShop()
	{
		PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
		SceneManager.LoadScene("MainGame");
	}

	public void resetPlayerPrefs()
	{
		moneyAmount = 0;
		mumButton.gameObject.SetActive (true);
		bombPrice.text = "Price: 10$";
		MumPrice.text = "Price: 5$";
		BirdPrice.text = "Price: 5$";
		PlayerPrefs.DeleteAll ();
	}
}
