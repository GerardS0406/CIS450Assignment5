/*
 * Gerard Lamoureux
 * SimpleZombieFactory
 * Assignment 5
 * Gets the zombie prefab provided the string type
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleZombieFactory : MonoBehaviour
{
    [SerializeField] private GameObject baseZombiePrefab;
    [SerializeField] private GameObject dogZombiePrefab;
    [SerializeField] private GameObject bossZombiePrefab;

    private GameObject zombieToSpawn;

    public GameObject CreateZombie(string type)
    {
        zombieToSpawn = null;

        switch(type)
        {
            case "baseZombie":
                zombieToSpawn = baseZombiePrefab;
                break;
            case "dogZombie":
                zombieToSpawn = dogZombiePrefab;
                break;
            case "bossZombie":
                zombieToSpawn = bossZombiePrefab;
                break;
        }

        return zombieToSpawn;
    }

}
