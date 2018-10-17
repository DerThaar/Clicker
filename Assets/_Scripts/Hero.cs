using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hero : MonoBehaviour
{	
	Click Click;
	Upgrade Upgrade;
	PassivClick PassivClick;
	NumberHelper helper;

	public Button buttonSword;
	public Button buttonFighter;
	public Button buttonCleric;
	public Button buttonMage;
	public Button buttonRogue;
	public Button buttonRanger;
	public Button buttonPaladin;

	public bool upgradeS;

	public float costSword = 15;
	public float costFighter = 100;
	public float costCleric = 1100;
	public float costMage = 12000;
	public float costRogue = 130000;
	public float costRanger = 1400000;
	public float costPaladin = 20000000;

	public int levelSword = 0;
	public int levelFighter = 0;
	public int levelCleric = 0;
	public int levelMage = 0;
	public int levelRogue = 0;
	public int levelRanger = 0;
	public int levelPaladin = 0;

	public float bonusS;

	public float levelAll;

	public TextMeshProUGUI goldInBankNumber;

	public TextMeshProUGUI levelS;
	public TextMeshProUGUI levelF;
	public TextMeshProUGUI levelC;
	public TextMeshProUGUI levelM;
	public TextMeshProUGUI levelRo;
	public TextMeshProUGUI levelRa;
	public TextMeshProUGUI levelP;

	public TextMeshProUGUI costS;
	public TextMeshProUGUI costF;
	public TextMeshProUGUI costC;
	public TextMeshProUGUI costM;
	public TextMeshProUGUI costRo;
	public TextMeshProUGUI costRa;
	public TextMeshProUGUI costP;

	float maxGold = 18446744073709551615;
	float gold;


	void Start()
	{
		Click = GetComponent<Click>();
		Upgrade = GetComponent<Upgrade>();
		PassivClick = GetComponent<PassivClick>();
		helper = GetComponent<NumberHelper>();
	}

	void Update()
	{
		if (Time.timeScale == 0) return;

		levelAll = levelSword + levelFighter + levelCleric + levelMage + levelRogue + levelRanger + levelPaladin;
		gold = Click.goldHave;

		UpdatingInteractability(costSword, buttonSword);
		UpdatingInteractability(costFighter, buttonFighter);
		UpdatingInteractability(costCleric, buttonCleric);
		UpdatingInteractability(costMage, buttonMage);
		UpdatingInteractability(costRogue, buttonRogue);
		UpdatingInteractability(costRanger, buttonRanger);
		UpdatingInteractability(costPaladin, buttonPaladin);

		UpdatingCosts(costSword, costS);
		UpdatingCosts(costFighter, costF);
		UpdatingCosts(costCleric, costC);
		UpdatingCosts(costMage, costM);
		UpdatingCosts(costRogue, costRo);
		UpdatingCosts(costRanger, costRa);
		UpdatingCosts(costPaladin, costP);

		UpdatingLevels();

		if (Upgrade.upgradeLevelS >= 3)
		{
			upgradeS = true;
		}
	}

	void UpdatingInteractability(float cost, Button button)
	{
		if (cost <= gold)
		{
			if (cost >= maxGold)
			{
				button.interactable = false;
			}
			else
			{
				button.interactable = true;
			}
		}
		else
		{
			button.interactable = false;
		}
	}

	void UpdatingLevels()
	{
		levelS.text = $"Level {levelSword}";
		levelF.text = $"Level {levelFighter}";
		levelC.text = $"Level {levelCleric}";
		levelM.text = $"Level {levelMage}";
		levelRo.text = $"Level {levelRogue}";
		levelRa.text = $"Level {levelRanger}";
		levelP.text = $"Level {levelPaladin}";
	}

	void UpdatingCosts(float cost, TextMeshProUGUI text)
	{
		text.text = helper.GoldCalculation(cost);
	}

	public void Sword()
	{
		Vector2 calc = calcLevelUp(costSword, levelSword, 15);
		costSword = calc.x;
		levelSword = (int)calc.y;
	}

	public void Fighter()
	{
		Vector2 calc = calcLevelUp(costFighter, levelFighter, 100);
		costFighter = calc.x;
		levelFighter = (int)calc.y;
		if (upgradeS)
		{
			Click.goldGet += bonusS;
			PassivClick.upgradeLevelSword += bonusS;
		}
	}

	public void Cleric()
	{
		Vector2 calc = calcLevelUp(costCleric, levelCleric, 1100);
		costCleric = calc.x;
		levelCleric = (int)calc.y;
		if (upgradeS)
		{
			Click.goldGet += bonusS;
			PassivClick.upgradeLevelSword += bonusS;
		}
	}

	public void Mage()
	{
		Vector2 calc = calcLevelUp(costMage, levelMage, 12000);
		costMage = calc.x;
		levelMage = (int)calc.y;
		if (upgradeS)
		{
			Click.goldGet += bonusS;
			PassivClick.upgradeLevelSword += bonusS;
		}
	}

	public void Rogue()
	{
		Vector2 calc = calcLevelUp(costRogue, levelRogue, 130000);
		costRogue = calc.x;
		levelRogue = (int)calc.y;
		if (upgradeS)
		{
			Click.goldGet += bonusS;
			PassivClick.upgradeLevelSword += bonusS;
		}
	}

	public void Ranger()
	{
		Vector2 calc = calcLevelUp(costRanger, levelRanger, 1400000);
		costRanger = calc.x;
		levelRanger = (int)calc.y;
		if (upgradeS)
		{
			Click.goldGet += bonusS;
			PassivClick.upgradeLevelSword += bonusS;
		}
	}

	public void Paladin()
	{		
		Vector2 calc = calcLevelUp(costPaladin, levelPaladin, 20000000);
		costPaladin = calc.x;
		levelPaladin = (int)calc.y;
		if (upgradeS)
		{
			Click.goldGet += bonusS;
			PassivClick.upgradeLevelSword += bonusS;
		}
	}

	Vector2 calcLevelUp(float cost, float level, int price)
	{
		if (gold >= cost)
		{
			Click.goldHave = gold - cost;
			level += 1;
			cost = price * Mathf.Pow(1.15f, level);
			cost = Mathf.Round(cost);			
		}
		return new Vector2(cost, level);
	}
}
