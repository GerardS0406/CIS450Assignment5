/*
 * Gerard Lamoureux
 * ZombieScriptFactory
 * Assignment 5
 * Adds script to zombie gameObject provided type
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScriptFactory : MonoBehaviour
{
    public void AddZombieScript(GameObject zombieInstance, string zombieType)
    {
        switch (zombieType)
        {
            case "baseZombie":
                if(zombieInstance.GetComponent<BasicZombie>() == null)
                    zombieInstance.AddComponent<BasicZombie>();
                break;
            case "dogZombie":
                if (zombieInstance.GetComponent<DogZombie>() == null)
                    zombieInstance.AddComponent<DogZombie>();
                break;
            case "bossZombie":
                if (zombieInstance.GetComponent<BossZombie>() == null)
                    zombieInstance.AddComponent<BossZombie>();
                break;
        }
    }
}
