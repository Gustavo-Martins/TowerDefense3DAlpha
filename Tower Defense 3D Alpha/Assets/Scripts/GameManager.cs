using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // Singleton pattern
    public static GameManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one GameManager in scene!");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject missileTurretPrefab;
    public GameObject laserTurretPrefab;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }

}
