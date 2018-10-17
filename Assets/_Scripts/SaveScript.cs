using UnityEngine;

public class SaveScript : MonoBehaviour
{    
	public GameObject DeleteScreen;
	bool delete;
	float timer;
	float waitTime = 2f;

    public Click Click;
    public Hero Hero;
    public PassivClick PassivClick;  
	public Upgrade Upgrade;


    void Awake()
    {
        if (PlayerPrefs.HasKey("clickCounter") && PlayerPrefs.GetFloat("clickCounter") > 0)
        {
            Click.goldHave = PlayerPrefs.GetFloat("goldHave");
            Click.goldGet = PlayerPrefs.GetFloat("goldGet");
            Click.clickCounter = PlayerPrefs.GetFloat("clickCounter");
            Click.goldClicked = PlayerPrefs.GetFloat("goldClicked");
            Click.goldAllTime = PlayerPrefs.GetFloat("goldAllTime");
            Click.upgradeBonus = PlayerPrefs.GetFloat("upgradeBonus");

			Upgrade.costSwordUpgrade = PlayerPrefs.GetFloat("costSwordUpgrade");
			Upgrade.levelS = PlayerPrefs.GetFloat("levelS");
			Upgrade.upgradeLevelS = PlayerPrefs.GetInt("upgradeLevelS");
			Upgrade.costFighterUpgrade = PlayerPrefs.GetFloat("costFighterUpgrade");
			Upgrade.levelF = PlayerPrefs.GetFloat("levelF");
			Upgrade.upgradeLevelF = PlayerPrefs.GetInt("upgradeLevelF");
			Upgrade.costClericUpgrade = PlayerPrefs.GetFloat("costClericUpgrade");
			Upgrade.levelC = PlayerPrefs.GetFloat("levelC");
			Upgrade.upgradeLevelC = PlayerPrefs.GetInt("upgradeLevelC");
			Upgrade.costMageUpgrade = PlayerPrefs.GetFloat("costMageUpgrade");
			Upgrade.levelM = PlayerPrefs.GetFloat("levelM");
			Upgrade.upgradeLevelM = PlayerPrefs.GetInt("upgradeLevelM");
			Upgrade.costRogueUpgrade = PlayerPrefs.GetFloat("costRogueUpgrade");
			Upgrade.levelRo = PlayerPrefs.GetFloat("levelRo");
			Upgrade.upgradeLevelRo = PlayerPrefs.GetInt("upgradeLevelRo");
			Upgrade.costRangerUpgrade = PlayerPrefs.GetFloat("costRangerUpgrade");
			Upgrade.levelRa = PlayerPrefs.GetFloat("levelRa");
			Upgrade.upgradeLevelRa = PlayerPrefs.GetInt("upgradeLevelRa");
			Upgrade.costPaladinUpgrade = PlayerPrefs.GetFloat("costPaladinUpgrade");
			Upgrade.levelP = PlayerPrefs.GetFloat("levelP");
			Upgrade.upgradeLevelP = PlayerPrefs.GetInt("upgradeLevelP");
			Upgrade.costClickUpgrade = PlayerPrefs.GetFloat("costClickUpgrade");
			Upgrade.levelCli = PlayerPrefs.GetFloat("levelCli");
			Upgrade.upgradeLevelCli = PlayerPrefs.GetInt("upgradeLevelCli");

			PassivClick.upgradeLevelSword = PlayerPrefs.GetFloat("upgradeLevelSword");
			PassivClick.upgradeLevelFighter = PlayerPrefs.GetFloat("upgradeLevelFighter");
			PassivClick.upgradeLevelCleric = PlayerPrefs.GetFloat("upgradeLevelCleric");
			PassivClick.upgradeLevelMage = PlayerPrefs.GetFloat("upgradeLevelMage");
			PassivClick.upgradeLevelRogue = PlayerPrefs.GetFloat("upgradeLevelRogue");
			PassivClick.upgradeLevelRanger = PlayerPrefs.GetFloat("upgradeLevelRanger");
			PassivClick.upgradeLevelPaladin = PlayerPrefs.GetFloat("upgradeLevelPaladin");

			Hero.costSword = PlayerPrefs.GetFloat("costSword");
			Hero.costFighter = PlayerPrefs.GetFloat("costFighter");
            Hero.costCleric = PlayerPrefs.GetFloat("costCleric");
            Hero.costMage = PlayerPrefs.GetFloat("costMage");
            Hero.costRogue = PlayerPrefs.GetFloat("costRogue");
            Hero.costRanger = PlayerPrefs.GetFloat("costRanger");
            Hero.costPaladin = PlayerPrefs.GetFloat("costPaladin");

			Hero.levelSword = PlayerPrefs.GetInt("levelSword");
			Hero.levelFighter = PlayerPrefs.GetInt("levelFighter");
            Hero.levelCleric = PlayerPrefs.GetInt("levelCleric");
            Hero.levelMage = PlayerPrefs.GetInt("levelMage");
            Hero.levelRogue = PlayerPrefs.GetInt("levelRogue");
            Hero.levelRanger = PlayerPrefs.GetInt("levelRanger");
            Hero.levelPaladin = PlayerPrefs.GetInt("levelPaladin");

			Hero.bonusS = PlayerPrefs.GetFloat("bonusS");

		}
        else
        {
            Click.goldHave = 0;
            Click.goldGet = 1;
            Click.clickCounter = 0;
            Click.goldClicked = 0;
            Click.goldAllTime = 0;
            Click.upgradeBonus = 0;

			Upgrade.costSwordUpgrade = 100;
			Upgrade.levelS = 1;
			Upgrade.upgradeLevelS = 0;			
			Upgrade.costFighterUpgrade = 1000;
			Upgrade.levelF = 1;
			Upgrade.upgradeLevelF = 0;
			Upgrade.costClericUpgrade = 11000;
			Upgrade.levelC = 1;
			Upgrade.upgradeLevelC = 0;
			Upgrade.costMageUpgrade = 120000;
			Upgrade.levelM = 1;
			Upgrade.upgradeLevelM = 0;
			Upgrade.costRogueUpgrade = 1300000;
			Upgrade.levelRo = 1;
			Upgrade.upgradeLevelRo = 0;
			Upgrade.costRangerUpgrade = 14000000;
			Upgrade.levelRa = 1;
			Upgrade.upgradeLevelRa = 0;
			Upgrade.costPaladinUpgrade = 200000000;
			Upgrade.levelP = 1;
			Upgrade.upgradeLevelP = 0;
			Upgrade.costClickUpgrade = 50000;
			Upgrade.levelCli = 1000;
			Upgrade.upgradeLevelCli = 0;

			PassivClick.upgradeLevelSword = 1;
			PassivClick.upgradeLevelSword = 1;
			PassivClick.upgradeLevelFighter = 1;
			PassivClick.upgradeLevelCleric = 1;
			PassivClick.upgradeLevelMage = 1;
			PassivClick.upgradeLevelRogue = 1;
			PassivClick.upgradeLevelRanger = 1;
			PassivClick.upgradeLevelPaladin = 1;

			Hero.costSword = 15;
            Hero.costFighter = 100;
			Hero.costCleric = 1100;
            Hero.costMage = 12000;
            Hero.costRogue = 130000;
            Hero.costRanger = 1400000;
            Hero.costPaladin = 20000000;

			Hero.levelSword = 0;
            Hero.levelFighter = 0;
            Hero.levelCleric = 0;
            Hero.levelMage = 0;
            Hero.levelRogue = 0;
            Hero.levelRanger = 0;
            Hero.levelPaladin = 0;

			Hero.bonusS = 0;
        }
    }

    void Update()
    {
		if (delete)
		{
			timer += Time.deltaTime;
			if(timer > waitTime)
			{

				Click.goldHave = 0;
				Click.goldGet = 1;
				Click.clickCounter = 0;
				Click.goldClicked = 0;
				Click.goldAllTime = 0;
				Click.upgradeBonus = 0;

				Upgrade.costSwordUpgrade = 100;
				Upgrade.levelS = 1;
				Upgrade.upgradeLevelS = 0;
				Upgrade.costFighterUpgrade = 1000;
				Upgrade.levelF = 1;
				Upgrade.upgradeLevelF = 0;
				Upgrade.costClericUpgrade = 11000;
				Upgrade.levelC = 1;
				Upgrade.upgradeLevelC = 0;
				Upgrade.costMageUpgrade = 120000;
				Upgrade.levelM = 1;
				Upgrade.upgradeLevelM = 0;
				Upgrade.costRogueUpgrade = 1300000;
				Upgrade.levelRo = 1;
				Upgrade.upgradeLevelRo = 0;
				Upgrade.costRangerUpgrade = 14000000;
				Upgrade.levelRa = 1;
				Upgrade.upgradeLevelRa = 0;
				Upgrade.costPaladinUpgrade = 200000000;
				Upgrade.levelP = 1;
				Upgrade.upgradeLevelP = 0;
				Upgrade.costClickUpgrade = 50000;
				Upgrade.levelCli = 1000;
				Upgrade.upgradeLevelCli = 0;

				PassivClick.upgradeLevelSword = 1;
				PassivClick.upgradeLevelFighter = 1;
				PassivClick.upgradeLevelCleric = 1;
				PassivClick.upgradeLevelMage = 1;
				PassivClick.upgradeLevelRogue = 1;
				PassivClick.upgradeLevelRanger = 1;
				PassivClick.upgradeLevelPaladin = 1;

				Hero.costSword = 15;
				Hero.costFighter = 100;
				Hero.costCleric = 1100;
				Hero.costMage = 12000;
				Hero.costRogue = 130000;
				Hero.costRanger = 1400000;
				Hero.costPaladin = 20000000;

				Hero.levelSword = 0;
				Hero.levelFighter = 0;
				Hero.levelCleric = 0;
				Hero.levelMage = 0;
				Hero.levelRogue = 0;
				Hero.levelRanger = 0;
				Hero.levelPaladin = 0;

				Hero.bonusS = 0;

				Time.timeScale = 0f;
				delete = false;
				DeleteScreen.SetActive(false);
				timer = 0f;
			}
		}

        PlayerPrefs.SetFloat("goldHave", Click.goldHave);
        PlayerPrefs.SetFloat("goldGet", Click.goldGet);
        PlayerPrefs.SetFloat("clickCounter", Click.clickCounter);
        PlayerPrefs.SetFloat("goldClicked", Click.goldClicked);
        PlayerPrefs.SetFloat("goldAllTime", Click.goldAllTime);
        PlayerPrefs.SetFloat("upgradeBonus", Click.upgradeBonus);

		PlayerPrefs.SetFloat("costSwordUpgrade", Upgrade.costSwordUpgrade);
		PlayerPrefs.SetFloat("levelS", Upgrade.levelS);
		PlayerPrefs.SetInt("upgradeLevelS", Upgrade.upgradeLevelS);
		PlayerPrefs.SetFloat("costFighterUpgrade", Upgrade.costFighterUpgrade);
		PlayerPrefs.SetFloat("levelF", Upgrade.levelF);
		PlayerPrefs.SetInt("upgradeLevelF", Upgrade.upgradeLevelF);
		PlayerPrefs.SetFloat("costClericUpgrade", Upgrade.costClericUpgrade);
		PlayerPrefs.SetFloat("levelC", Upgrade.levelC);
		PlayerPrefs.SetInt("upgradeLevelC", Upgrade.upgradeLevelC);
		PlayerPrefs.SetFloat("costMageUpgrade", Upgrade.costMageUpgrade);
		PlayerPrefs.SetFloat("levelM", Upgrade.levelM);
		PlayerPrefs.SetInt("upgradeLevelM", Upgrade.upgradeLevelM);
		PlayerPrefs.SetFloat("costRogueUpgrade", Upgrade.costRogueUpgrade);
		PlayerPrefs.SetFloat("levelRo", Upgrade.levelRo);
		PlayerPrefs.SetInt("upgradeLevelRo", Upgrade.upgradeLevelRo);
		PlayerPrefs.SetFloat("costRangerUpgrade", Upgrade.costRangerUpgrade);
		PlayerPrefs.SetFloat("levelRa", Upgrade.levelRa);
		PlayerPrefs.SetInt("upgradeLevelRa", Upgrade.upgradeLevelRa);
		PlayerPrefs.SetFloat("costPaladinUpgrade", Upgrade.costPaladinUpgrade);
		PlayerPrefs.SetFloat("levelP", Upgrade.levelP);
		PlayerPrefs.SetInt("upgradeLevelP", Upgrade.upgradeLevelP);
		PlayerPrefs.SetFloat("costClickUpgrade", Upgrade.costClickUpgrade);
		PlayerPrefs.SetFloat("levelCli", Upgrade.levelCli);
		PlayerPrefs.SetInt("upgradeLevelCli", Upgrade.upgradeLevelCli);

		PlayerPrefs.SetFloat("upgradeLevelSword", PassivClick.upgradeLevelSword);
		PlayerPrefs.SetFloat("upgradeLevelFighter", PassivClick.upgradeLevelFighter);
		PlayerPrefs.SetFloat("upgradeLevelCleric", PassivClick.upgradeLevelCleric);
		PlayerPrefs.SetFloat("upgradeLevelMage", PassivClick.upgradeLevelMage);
		PlayerPrefs.SetFloat("upgradeLevelRogue", PassivClick.upgradeLevelRogue);
		PlayerPrefs.SetFloat("upgradeLevelRanger", PassivClick.upgradeLevelRanger);
		PlayerPrefs.SetFloat("upgradeLevelPaladin", PassivClick.upgradeLevelPaladin);

		PlayerPrefs.SetFloat("costSword", Hero.costSword);
		PlayerPrefs.SetFloat("costFighter", Hero.costFighter);
        PlayerPrefs.SetFloat("costCleric", Hero.costCleric);
        PlayerPrefs.SetFloat("costMage", Hero.costMage);
        PlayerPrefs.SetFloat("costRogue", Hero.costRogue);
        PlayerPrefs.SetFloat("costRanger", Hero.costRanger);
        PlayerPrefs.SetFloat("costPaladin", Hero.costPaladin);

		PlayerPrefs.SetInt("levelSword", Hero.levelSword);
		PlayerPrefs.SetInt("levelFighter", Hero.levelFighter);
        PlayerPrefs.SetInt("levelCleric", Hero.levelCleric);
        PlayerPrefs.SetInt("levelMage", Hero.levelMage);
        PlayerPrefs.SetInt("levelRogue", Hero.levelRogue);
        PlayerPrefs.SetInt("levelRanger", Hero.levelRanger);
        PlayerPrefs.SetInt("levelPaladin", Hero.levelPaladin);

		PlayerPrefs.SetFloat("bonusS", Hero.bonusS);
    }

	public void DeleteSave()
	{
		DeleteScreen.SetActive(true);

		Click.goldHave = 0;
		Click.goldGet = 1;
		Click.clickCounter = 0;
		Click.goldClicked = 0;
		Click.goldAllTime = 0;
		Click.upgradeBonus = 0;

		Upgrade.costSwordUpgrade = 100; if (Hero.upgradeS)
		{
			Click.goldGet += Hero.bonusS;
			PassivClick.upgradeLevelSword += Hero.bonusS;
		}
		Upgrade.levelS = 1;
		Upgrade.upgradeLevelS = 0;
		Upgrade.costFighterUpgrade = 1000;
		Upgrade.levelF = 1;
		Upgrade.upgradeLevelF = 0;
		Upgrade.costClericUpgrade = 11000;
		Upgrade.levelC = 1;
		Upgrade.upgradeLevelC = 0;
		Upgrade.costMageUpgrade = 120000;
		Upgrade.levelM = 1;
		Upgrade.upgradeLevelM = 0;
		Upgrade.costRogueUpgrade = 1300000;
		Upgrade.levelRo = 1;
		Upgrade.upgradeLevelRo = 0;
		Upgrade.costRangerUpgrade = 14000000;
		Upgrade.levelRa = 1;
		Upgrade.upgradeLevelRa = 0;
		Upgrade.costPaladinUpgrade = 200000000;
		Upgrade.levelP = 1;
		Upgrade.upgradeLevelP = 0;
		Upgrade.costClickUpgrade = 50000;
		Upgrade.levelCli = 1000;
		Upgrade.upgradeLevelCli = 0;

		PassivClick.upgradeLevelSword = 1;
		PassivClick.upgradeLevelFighter = 1;
		PassivClick.upgradeLevelCleric = 1;
		PassivClick.upgradeLevelMage = 1;
		PassivClick.upgradeLevelRogue = 1;
		PassivClick.upgradeLevelRanger = 1;
		PassivClick.upgradeLevelPaladin = 1;

		Hero.costSword = 15;
		Hero.costFighter = 100;
		Hero.costCleric = 1100;
		Hero.costMage = 12000;
		Hero.costRogue = 130000;
		Hero.costRanger = 1400000;
		Hero.costPaladin = 20000000;

		Hero.levelSword = 0;
		Hero.levelFighter = 0;
		Hero.levelCleric = 0;
		Hero.levelMage = 0;
		Hero.levelRogue = 0;
		Hero.levelRanger = 0;
		Hero.levelPaladin = 0;

		Hero.bonusS = 0;

		Time.timeScale = 1f;
		delete = true;
	}
}
