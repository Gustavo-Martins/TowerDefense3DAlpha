using UnityEngine;

public class Node : MonoBehaviour {

    public Color hoverColor;
    public Color startColor;

    private GameObject turret;

    private Renderer rend;
    public Vector3 positionOffSet;
    

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("You can't build there!");
            return;
        }

        GameObject turretToBuild = GameManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffSet, transform.rotation);

    }
       
    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
