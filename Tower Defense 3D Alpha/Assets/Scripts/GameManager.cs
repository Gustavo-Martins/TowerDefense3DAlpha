using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public Text goldCountText;
    public int goldCount = 10;

    private GameObject turretToBuid;

    void Update()
    {
        goldCountText.text = goldCount.ToString();
    }
    
    public GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }

}
