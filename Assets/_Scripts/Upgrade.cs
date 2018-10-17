using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Upgrade : MonoBehaviour
{
	public GameObject engine;
	public Click Click;
	public PassivClick PassivClick;
	public Hero Hero;

	public Button swordButton;
	public Button fighterButton;
	public Button clericButton;
	public Button mageButton;
	public Button rogueButton;
	public Button rangerButton;
	public Button paladinButton;
	public Button clickButton;

	public TextMeshProUGUI upgradeSwordText;
	public TextMeshProUGUI upgradeFighterText;
	public TextMeshProUGUI upgradeClericText;
	public TextMeshProUGUI upgradeMageText;
	public TextMeshProUGUI upgradeRogueText;
	public TextMeshProUGUI upgradeRangerText;
	public TextMeshProUGUI upgradePaladinText;
	public TextMeshProUGUI upgradeClickText;

	public float levelSword;
	public float levelFighter;
	public float levelCleric;
	public float levelMage;
	public float levelRogue;
	public float levelRanger;
	public float levelPaladin;
	public float levelClick;

	public float levelAll;

	public float costSwordUpgrade = 100;
	public float costFighterUpgrade = 1000;
	public float costClericUpgrade = 11000;
	public float costMageUpgrade = 120000;
	public float costRogueUpgrade = 1300000;
	public float costRangerUpgrade = 14000000;
	public float costPaladinUpgrade = 200000000;
	public float costClickUpgrade = 50000;

	public float levelS = 1;
	public float levelF = 1;
	public float levelC = 1;
	public float levelM = 1;
	public float levelRo = 1;
	public float levelRa = 1;
	public float levelP = 1;
	public float levelCli = 1000;

	public int upgradeLevelS;
	public int upgradeLevelF;
	public int upgradeLevelC;
	public int upgradeLevelM;
	public int upgradeLevelRo;
	public int upgradeLevelRa;
	public int upgradeLevelP;
	public int upgradeLevelCli;

	float gold;
	bool isSword;


	void Update()
	{
		if (Time.timeScale == 0) return;

		gold = Click.goldHave;

		levelSword = Hero.levelSword;
		levelFighter = Hero.levelFighter;
		levelCleric = Hero.levelCleric;
		levelMage = Hero.levelMage;
		levelRogue = Hero.levelRogue;
		levelRanger = Hero.levelRanger;
		levelPaladin = Hero.levelPaladin;
		levelClick = Click.goldClicked;

		levelAll = Hero.levelAll;

		upgradeSwordText.text = upgradeLevelS + 1 + "";
		upgradeFighterText.text = upgradeLevelF + 1 + "";
		upgradeClericText.text = upgradeLevelC + 1 + "";
		upgradeMageText.text = upgradeLevelM + 1 + "";
		upgradeRogueText.text = upgradeLevelRo + 1 + "";
		upgradeRangerText.text = upgradeLevelRa + 1 + "";
		upgradePaladinText.text = upgradeLevelP + 1 + "";
		upgradeClickText.text = upgradeLevelCli + 1 + "";

		UpgradeHero(upgradeLevelS, 7, swordButton, levelS, levelSword, costSwordUpgrade);
		UpgradeHero(upgradeLevelF, 7, fighterButton, levelF, levelFighter, costFighterUpgrade);
		UpgradeHero(upgradeLevelC, 7, clericButton, levelC, levelCleric, costClericUpgrade);
		UpgradeHero(upgradeLevelM, 7, mageButton, levelM, levelMage, costMageUpgrade);
		UpgradeHero(upgradeLevelRo, 7, rogueButton, levelRo, levelRogue, costRogueUpgrade);
		UpgradeHero(upgradeLevelRa, 7, rangerButton, levelRa, levelRanger, costRangerUpgrade);
		UpgradeHero(upgradeLevelP, 7, paladinButton, levelP, levelPaladin, costPaladinUpgrade);
		UpgradeClick();
	}

	void UpgradeHero(int upgradeLevel, int maxLevel, Button button, float tempUpgradeLevel, float levelHero, float costUpgrade)
	{
		if (upgradeLevel == maxLevel)
		{
			button.interactable = false;
		}
		else if (tempUpgradeLevel <= levelHero && costUpgrade <= gold)
		{
			button.interactable = true;
		}
		else
		{
			button.interactable = false;
		}
	}
	
	void UpgradeClick()
	{
		if (upgradeLevelCli == 8)
		{
			clickButton.interactable = false;
		}
		else if (levelClick >= levelCli && costClickUpgrade <= gold)
		{
			clickButton.interactable = true;
		}
		else
		{
			clickButton.interactable = false;
		}
	}

	public void UseUpgradeSword()
	{
		isSword = true;
		float upgradeHeroLevel = PassivClick.upgradeLevelSword;
		Vector4 useUpgrade = UseUpgrade(levelSword, upgradeLevelS, levelS, upgradeHeroLevel, costSwordUpgrade, 100, 500, 10000, 100000, 10000000, 100000000, 1000000000);		
		PassivClick.upgradeLevelSword = useUpgrade.x;
		costSwordUpgrade = useUpgrade.y;
		upgradeLevelS = (int)useUpgrade.z;
		levelS = useUpgrade.w;
		isSword = false;
	}

	public void UseUpgradeFighter()
	{
		float upgradeHeroLevel = PassivClick.upgradeLevelFighter;
		Vector4 useUpgrade = UseUpgrade(levelFighter, upgradeLevelF, levelF, upgradeHeroLevel, costFighterUpgrade, 1000, 5000, 50000, 5000000, 500000000, 50000000000, 50000000000000);
		PassivClick.upgradeLevelFighter = useUpgrade.x;
		costFighterUpgrade = useUpgrade.y;
		upgradeLevelF = (int)useUpgrade.z;
		levelF = useUpgrade.w;
	}

	public void UseUpgradeCleric()
	{
		float upgradeHeroLevel = PassivClick.upgradeLevelCleric;
		Vector4 useUpgrade = UseUpgrade(levelCleric, upgradeLevelC, levelC, upgradeHeroLevel, costClericUpgrade, 11000, 55000, 550000, 55000000, 5500000000, 550000000000, 550000000000000);
		PassivClick.upgradeLevelCleric = useUpgrade.x;
		costClericUpgrade = useUpgrade.y;
		upgradeLevelC = (int)useUpgrade.z;
		levelC = useUpgrade.w;
	}

	public void UseUpgradeMage()
	{
		float upgradeHeroLevel = PassivClick.upgradeLevelMage;
		Vector4 useUpgrade = UseUpgrade(levelMage, upgradeLevelM, levelM, upgradeHeroLevel, costMageUpgrade, 120000, 600000, 6000000, 600000000, 60000000000, 6000000000000, 6000000000000000);
		PassivClick.upgradeLevelMage = useUpgrade.x;
		costMageUpgrade = useUpgrade.y;
		upgradeLevelM = (int)useUpgrade.z;
		levelM = useUpgrade.w;
	}

	public void UseUpgradeRogue()
	{
		float upgradeHeroLevel = PassivClick.upgradeLevelRogue;
		Vector4 useUpgrade = UseUpgrade(levelRogue, upgradeLevelRo, levelRo, upgradeHeroLevel, costRogueUpgrade, 1300000, 6500000, 65000000, 6500000000, 650000000000, 65000000000000, 65000000000000000);
		PassivClick.upgradeLevelRogue = useUpgrade.x;
		costRogueUpgrade = useUpgrade.y;
		upgradeLevelRo = (int)useUpgrade.z;
		levelRo = useUpgrade.w;
	}

	public void UseUpgradeRanger()
	{
		float upgradeHeroLevel = PassivClick.upgradeLevelRanger;
		Vector4 useUpgrade = UseUpgrade(levelRanger, upgradeLevelRa, levelRa, upgradeHeroLevel, costRangerUpgrade, 14000000, 70000000, 700000000, 70000000000, 7000000000000, 700000000000000, 700000000000000000);
		PassivClick.upgradeLevelRanger = useUpgrade.x;
		costRangerUpgrade = useUpgrade.y;
		upgradeLevelRa = (int)useUpgrade.z;
		levelRa = useUpgrade.w;
	}

	public void UseUpgradePaladin()
	{
		float upgradeHeroLevel = PassivClick.upgradeLevelPaladin;
		Vector4 useUpgrade = UseUpgrade(levelPaladin, upgradeLevelP, levelP, upgradeHeroLevel, costPaladinUpgrade, 200000000, 1000000000, 10000000000, 1000000000000, 100000000000000, 10000000000000000, 10000000000000000000);
		PassivClick.upgradeLevelPaladin = useUpgrade.x;
		costPaladinUpgrade = useUpgrade.y;
		upgradeLevelP = (int)useUpgrade.z;
		levelP = useUpgrade.w;
	}

	Vector4 UseUpgrade(float levelHero, int upgradeLevel, float tempLevel, float upgradeHeroLevel, float upgradeCost, float cost1, float cost2, float cost3, float cost4, float cost5, float cost6, float cost7)
	{
		if (levelHero >= 1 && upgradeLevel == 0)
		{
			if (isSword) Click.goldGet *= 2;
			upgradeHeroLevel *= 2;
			Click.goldHave -= cost1;

			upgradeCost = cost2;
			upgradeLevel += 1;
			tempLevel = 5;
		}
		else if (levelHero >= 5 && upgradeLevel == 1)
		{
			if (isSword) Click.goldGet *= 2;
			upgradeHeroLevel *= 2;
			Click.goldHave -= cost2;

			upgradeCost = cost3;
			upgradeLevel += 1;
			tempLevel = 25;
		}
		else if (levelHero >= 25 && upgradeLevel == 2)
		{
			if (isSword) Click.goldGet *= 2;
			upgradeHeroLevel *= 2;
			Click.goldHave -= cost3;

			upgradeCost = cost4;
			upgradeLevel += 1;
			tempLevel = 50;
		}
		else if (levelHero >= 50 && upgradeLevel == 3)
		{
			if (isSword)
			{
				float bonus = levelAll - levelSword;
				bonus *= 0.1f;
				Click.goldGet += bonus;
				PassivClick.upgradeLevelSword += bonus;
				Hero.bonusS = 0.1f;
			}
			else upgradeHeroLevel *= 2;
			Click.goldHave -= cost4;

			upgradeCost = cost5;
			upgradeLevel += 1;
			tempLevel = 100;
		}
		else if (levelHero >= 100 && upgradeLevel == 4)
		{
			if (isSword)
			{
				float bonus = levelAll - levelSword;
				bonus *= 0.5f;
				Click.goldGet += bonus;
				PassivClick.upgradeLevelSword += bonus;
				Hero.bonusS = 0.5f;
			}
			else upgradeHeroLevel *= 2;
			Click.goldHave -= cost5;

			upgradeCost = cost6;
			upgradeLevel += 1;
			tempLevel = 150;
		}
		else if (levelHero >= 150 && upgradeLevel == 5)
		{
			if (isSword)
			{
				float bonus = levelAll - levelSword;
				bonus *= 5f;
				Click.goldGet += bonus;
				PassivClick.upgradeLevelSword += bonus;
				Hero.bonusS = 5f;
			}
			else upgradeHeroLevel *= 2;
			Click.goldHave -= cost6;

			upgradeCost = cost7;
			upgradeLevel += 1;
			tempLevel = 200;
		}	
		else if (levelHero >= 200 && upgradeLevel == 6)
		{
			if (isSword)
			{
				float bonus = levelAll - levelSword;
				bonus *= 50f;
				Click.goldGet += bonus;
				PassivClick.upgradeLevelSword += bonus;
				Hero.bonusS = 50f;
			}
			else upgradeHeroLevel *= 2;
			Click.goldHave -= cost7;			
			upgradeLevel += 1;			
		}

		return new Vector4(upgradeHeroLevel, upgradeCost, upgradeLevel, tempLevel);
	}
	

	public void UseUpgradeClick()
	{
		if (levelClick >= levelCli && upgradeLevelCli == 0)
		{
			Click.upgradeBonus += 1;
			Click.goldHave -= 50000;
			levelCli = 100000;
			costClickUpgrade = 5000000;
			upgradeLevelCli += 1;
		}
		else if (levelClick >= levelCli && upgradeLevelCli == 1)
		{
			Click.upgradeBonus += 1;
			Click.goldHave -= 5000000;
			levelCli = 10000000;
			costClickUpgrade = 500000000;
			upgradeLevelCli += 1;
		}
		else if (levelClick >= levelCli && upgradeLevelCli == 2)
		{
			Click.upgradeBonus += 1;
			Click.goldHave -= 500000000;
			levelCli = 1000000000;
			costClickUpgrade = 50000000000;
			upgradeLevelCli += 1;
		}
		else if (levelClick >= levelCli && upgradeLevelCli == 3)
		{
			Click.upgradeBonus += 1;
			Click.goldHave -= 50000000000;
			levelCli = 100000000000;
			costClickUpgrade = 5000000000000;
			upgradeLevelCli += 1;
		}
		else if (levelClick >= levelCli && upgradeLevelCli == 4)
		{
			Click.upgradeBonus += 1;
			Click.goldHave -= 5000000000000;
			levelCli = 10000000000000;
			costClickUpgrade = 500000000000000;
			upgradeLevelCli += 1;
		}
		else if (levelClick >= levelCli && upgradeLevelCli == 5)
		{
			Click.upgradeBonus += 1;
			Click.goldHave -= 500000000000000;
			levelCli = 1000000000000000;
			costClickUpgrade = 50000000000000000;
			upgradeLevelCli += 1;
		}
		else if (levelClick >= levelCli && upgradeLevelCli == 6)
		{
			Click.upgradeBonus += 1;
			Click.goldHave -= 50000000000000000;
			levelCli = 100000000000000000;
			costClickUpgrade = 5000000000000000000;
			upgradeLevelCli += 1;
		}
		else if (levelClick >= levelCli && upgradeLevelCli == 7)
		{
			Click.upgradeBonus += 1;
			Click.goldHave -= 5000000000000000000;			
			upgradeLevelCli += 1;
		}
	}
}
