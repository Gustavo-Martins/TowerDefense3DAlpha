using UnityEngine;

public class Shop : MonoBehaviour {

    GameManager gameManager;

    void Start()
    {
        gameManager = GameManager.instance;
    }

    public void PurchaseStandardTurret()
    {
        Debug.Log("Standard Turret purchased");
        gameManager.SetTurretToBuild(gameManager.standardTurretPrefab);
    }

    public void PurchaseMissileTurret()
    {
        Debug.Log("Missile Turret purchased");
        gameManager.SetTurretToBuild(gameManager.missileTurretPrefab);
    }

    public void PurchaseLaserTurret()
    {
        Debug.Log("Laser Turret purchased");
        gameManager.SetTurretToBuild(gameManager.laserTurretPrefab);
    }
}
