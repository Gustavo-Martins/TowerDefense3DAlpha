using UnityEngine;

public class Node : MonoBehaviour
{

    public Color hoverColor;
    public Color startColor;

    private GameObject _turret;

    private Renderer rend;
    public Vector3 positionOffSet;

    GameManager gameManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        gameManager = GameManager.instance;
    }

    void OnMouseDown()
    {
        if (gameManager.GetTurretToBuild() == null)
        {
            return;
        }

        if (_turret != null)
        {
            Debug.Log("You can't build there!");
            return;
        }

        GameObject turretToBuild = GameManager.instance.GetTurretToBuild();
        Turret turret = turretToBuild.GetComponent<Turret>();
        
        if (GameManager.instance.goldCount < turret.goldCost)
        {
            return;
        }

        GameManager.instance.goldCount -= turret.goldCost;
        _turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffSet, transform.rotation);
    }

    void OnMouseEnter()
    {
        if (gameManager.GetTurretToBuild() == null)
        {
            return;
        }

        GetComponent<Renderer>().material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}