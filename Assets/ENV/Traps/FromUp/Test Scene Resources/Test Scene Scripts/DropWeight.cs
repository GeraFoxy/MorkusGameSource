using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// A controller/UI class to drop a weight wherever the user clicks
/// </summary>
public class DropWeight : MonoBehaviour {
	public float dropHeight = 10.0f;
	public GameObject[] dropObject;
	public string[] selectionText;
	public GUISkin guiSkin;
	
	private float timeSinceLast = 0.0f;
	private int selWeight = 0;
	private bool displayHelp = true;
	private int weightCount = 0;

	// Update is called once per frame
	void Update () {
		if((timeSinceLast>0.25f)&&(Input.GetMouseButtonDown(0)==true)&&(dropObject != null)) {
			//Find drop point
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit, Mathf.Infinity)==true) {
				//Check to make sure this is a legal drop point by checking the tag
				if(hit.collider.tag != "NoDrop") {
					Vector3 dropPos = new Vector3(hit.point.x, hit.point.y + dropHeight, hit.point.z);
					GameObject tmp = (GameObject)Instantiate(dropObject[selWeight], dropPos, dropObject[selWeight].transform.rotation);
					weightCount++;
					
					//Just to keep things cleaner in the editor
					tmp.transform.parent = this.transform;
					
					//Reset inhibit timer for next drop
					timeSinceLast = 0.0f;				
					displayHelp = false;
				}
			}
		}
		
		timeSinceLast += Time.deltaTime;
	}
	
	void OnGUI() {
		selWeight = GUI.SelectionGrid(new Rect(10,40,140,20 * dropObject.Length), selWeight, selectionText, 1, guiSkin.button);
		if(weightCount>0) {
			if(GUI.Button(new Rect(10,10,70,20),"RESET",guiSkin.button)==true) {
				Application.LoadLevel(Application.loadedLevelName);
			}
		}
		if(displayHelp==true) {
			GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 45, 200, 20), "Select the weight type above then", guiSkin.label);
			GUI.Label(new Rect(Screen.width / 2 - 100,Screen.height - 30, 200, 20),"Click on a surface to drop a weight",guiSkin.label);
		}
	}	
}
