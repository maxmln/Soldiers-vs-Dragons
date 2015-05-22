using UnityEngine;
using System.Collections;

public class Level1 : Levels{

    public static bool isLevelCompleted = false;

    public GameObject dragonFly;
    public GameObject dragonWarrior;
    public GameObject dragonKnight;
    public GameObject whiteDragon;

    void Start()
    {
        addEnemy(dragonFly, 14);
        addEnemy(dragonFly, 20);
        addEnemy(dragonFly, 23);
        addEnemy(dragonFly, 25);
        addEnemy(dragonFly, 27);
        addEnemy(dragonFly, 26);
        addEnemy(dragonFly, 28);
        addEnemy(dragonFly, 30);
        addEnemy(dragonFly, 32);
        addEnemy(dragonFly, 35);
        addEnemy(dragonFly, 31);
        addEnemy(dragonFly, 36);
        addEnemy(dragonFly, 37);
        addEnemy(dragonFly, 38);
        addEnemy(dragonFly, 40);
        addEnemy(dragonFly, 42);
        addEnemy(dragonFly, 43);
	}
	
	// Update is called once per frame
	void Update () {
        goToNextLevel();
	}

}