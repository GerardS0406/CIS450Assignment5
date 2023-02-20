/*
 * Gerard Lamoureux
 * ZombieSpawner
 * Assignment 5
 * Takes Random Zombie Type from List of strings and Spawns a Zombie
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public SimpleZombieFactory zombieFactory;
    public ZombieScriptFactory zombieScriptFactory;
    public List<string> zombieTypes = new List<string>();

    private string zombieType;

    public void SpawnZombie()
    {
        zombieType = null;
        if(zombieTypes.Count>0)
            zombieType = zombieTypes[Random.Range(0, zombieTypes.Count)];
        GameObject zombie = zombieFactory.CreateZombie(zombieType);
        GameObject zombieObject = Instantiate(zombie, transform.position, Quaternion.identity);
        zombieScriptFactory.AddZombieScript(zombieObject, zombieType);
    }
}
