using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI goldInBankNumber;
	public float goldAllTime;
	public float clickCounter;
	public float goldClicked;
	public float goldBonusGet;
	public float upgradeBonus;
	public float goldHave;
	public float goldGet;

	PassivClick PassivClick;
	NumberHelper helper;


	void Start()
	{
		PassivClick = GetComponent<PassivClick>();
		helper = GetComponent<NumberHelper>();
	}

	void Update()
	{
		GoldCalculation();
	}

	public void ClickOnEnemy()
	{
		goldHave += goldGet + goldBonusGet;
		goldClicked += goldGet + goldBonusGet;
		clickCounter += 1;
		goldAllTime += goldGet;
	}

	void GoldCalculation()
	{
		if (Time.timeScale == 0) return;
		
		goldInBankNumber.text = helper.GoldCalculation(goldHave);
		goldBonusGet = PassivClick.passivGold * 0.01f;
		goldBonusGet *= upgradeBonus;
	}
}
