using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour {

	public Color hoverColor;
	public Color notEnoughMoneyColor;
    public Vector3 positionOffset;

	//TODO: Task 1 : bind turretTemplate to turret prefab in Inspector
	public GameObject turretTemplate;

	[HideInInspector]
	public GameObject turret;

	private void Start()
	{
		turret = null;
	}
	private void Update()
	{
		
	}
	public Vector3 GetBuildPosition ()
	{
		return transform.position + positionOffset;
	}

	void OnMouseDown ()
	{
		if (EventSystem.current.IsPointerOverGameObject())
			return;


		//TODO: Task 1: if tower exists on this node, then destroy it; else create a turret.
	}

	void BuildTurret (GameObject __turret)
	{
		
		// TODO: Task 1 : Implement turret building logic
		Debug.Log("Turret build!");
	}


	public void DestroyTurret ()
	{
		// TODO: Task 1 : Implement turret destroy logic
	}



}
