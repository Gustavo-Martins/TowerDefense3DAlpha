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
    public Text lifeCountText;
    public int lifeCount = 10;

    private GameObject turretToBuid;

    void Update()
    {
        goldCountText.text = goldCount.ToString();
        lifeCountText.text = lifeCount.ToString();

        if (lifeCount <= 0)
        {
            // Stops if Game Over
            WaveSpawner waveSpawner = GetComponent<WaveSpawner>();
            waveSpawner.enabled = false;
        }
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
