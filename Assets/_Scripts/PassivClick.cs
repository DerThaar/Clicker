using UnityEngine;
using TMPro;

public class PassivClick : MonoBehaviour
{
	public TextMeshProUGUI goldPerSecondNumber;

	public float levelS;
	public float levelF;
	public float levelC;
	public float levelM;
	public float levelRo;
	public float levelRa;
	public float levelP;
	public float upgradeLevelSword = 1;
	public float upgradeLevelFighter = 1;
	public float upgradeLevelCleric = 1;
	public float upgradeLevelMage = 1;
	public float upgradeLevelRogue = 1;
	public float upgradeLevelRanger = 1;
	public float upgradeLevelPaladin = 1;
	public float passivGold = 0f;
	public float fps;
	public float passivGoldGet = 0f;

	Click click;
	Hero hero;

	float timerGold;
	float waitTime = 1f;
	float gold;
	float passivGoldText;


	void Start()
	{
		click = GetComponent<Click>();
		hero = GetComponent<Hero>();
	}

	void Update()
	{
		if (Time.timeScale == 0) return;

		gold = click.goldHave;
		fps += 1f;

		levelS = Gold(levelS, hero.levelSword, 0.1f, upgradeLevelSword);
		levelF = Gold(levelF, hero.levelFighter, 1f, upgradeLevelFighter);
		levelC = Gold(levelC, hero.levelCleric, 8f, upgradeLevelCleric);
		levelM = Gold(levelM, hero.levelMage, 47f, upgradeLevelMage);
		levelRo = Gold(levelRo, hero.levelRogue, 260f, upgradeLevelRogue);
		levelRa = Gold(levelRa, hero.levelRanger, 1400f, upgradeLevelRanger);
		levelP = Gold(levelP, hero.levelPaladin, 7800f, upgradeLevelPaladin);

		passivGold = levelS + levelF + levelC + levelM + levelRo + levelRa + levelP;
		passivGoldText = Mathf.Round(passivGold * 10) / 10;
		goldPerSecondNumber.text = passivGoldText.ToString();

		timerGold += Time.deltaTime;
		if (timerGold > waitTime)
		{
			passivGold /= fps;
			passivGoldGet = passivGold;
			fps = 0f;
			timerGold = 0f;
		}

		gold += passivGoldGet;
		click.goldAllTime += passivGoldGet;
		click.goldHave = gold;
	}

	float Gold(float level, int heroLevel, float factor, float upgradeLevel)
	{
		level = heroLevel;
		level *= factor;
		level *= upgradeLevel;
		return level;
	}
}

