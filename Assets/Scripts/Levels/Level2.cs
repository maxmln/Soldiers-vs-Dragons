using UnityEngine;
using System.Collections;

public class Level2 : Levels {

    public static bool isLevelCompleted = false;

    public GameObject dragonFly;
    public GameObject dragonWarrior;
    public GameObject dragonKnight;
    public GameObject whiteDragon;

    void Start()
    {
        addEnemy(dragonFly, 14);

        addEnemy(dragonFly, 21);
        addEnemy(dragonFly, 23);
        addEnemy(dragonFly, 25);

        addEnemy(dragonFly, 30);

        addEnemy(dragonWarrior, 32);
        addEnemy(dragonFly, 34);
        addEnemy(dragonFly, 36);
        addEnemy(dragonFly, 38);

        addEnemy(dragonWarrior, 44, 1);
        addEnemy(dragonWarrior, 44, 3);
        addEnemy(dragonFly, 46);
        addEnemy(dragonFly, 48);
        addEnemy(dragonFly, 50);

        addEnemy(dragonWarrior, 55);
        addEnemy(dragonWarrior, 56);
        addEnemy(dragonWarrior, 57);
}

	
	// Update is called once per frame
	void Update () {
        goToNextLevel();
	}
}
