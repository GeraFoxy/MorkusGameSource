using UnityEngine;
using System.Collections;

/// <summary>
/// Just a simple class for creating an array of elements
/// </summary>
public class WallCreator : MonoBehaviour {
	public GameObject elementPrefab;
	public int wall_X_Length = 10;
	public int wall_Z_Length = 1;
	public int wall_Y_Height = 8;
	public float element_X_increment = 0.4064f;
	public float element_Z_increment = 0.2032f;
	public float element_Y_increment = 0.2f;
	public float element_breakforce = 0.1f;
	public float element_breaktorque = 0.1f;

	/// <summary>
	/// An offset to be applied every other layer
	/// </summary>
	public Vector3 offset_per_Y_increment = new Vector3(0.2032f, 0, 0);
	private GameObject[,,] _wall;
	// Use this for initialization
	void Start () {
		BuildWall();
	}
		
	/// <summary>
	/// Build a wall using the elementPrefab
	/// </summary>
	private void BuildWall() {
		if(_wall == null)
			_wall = new GameObject[wall_X_Length, wall_Y_Height, wall_Z_Length];
		
		if(elementPrefab != null) {
			Vector3 current_offset = Vector3.zero;
			Vector3 nxPos = Vector3.zero;
			for(int yy=0;yy<wall_Y_Height;yy++) {
				for(int xx=0;xx<wall_X_Length;xx++) {
					for(int zz=0;zz<wall_Z_Length;zz++) {
						//nxPos = transform.position + new Vector3(xx*element_X_increment, yy*element_Y_increment, zz*element_Z_increment) + current_offset;
						nxPos = transform.position + transform.right * (xx * element_X_increment + current_offset.x) 
						                                                + transform.up * (yy * element_Y_increment + current_offset.y) 
						                                                + transform.forward * (zz * element_Z_increment + current_offset.z);
						//Create the next element in the wall
						GameObject tmp = (GameObject)Instantiate(elementPrefab, nxPos, transform.rotation);
						tmp.transform.parent = this.transform;
						_wall[xx,yy,zz] = tmp;
						
						//create fixed joints to make a more realistic wall
						if(xx>0) {
							FixedJoint fj = _wall[xx,yy,zz].AddComponent<FixedJoint>();
							fj.connectedBody = _wall[xx-1,yy,zz].GetComponent<Rigidbody>();
							fj.breakForce = element_breakforce;
							fj.breakTorque = element_breaktorque;							
						}
						if(yy>0) {
							FixedJoint fj = _wall[xx,yy,zz].AddComponent<FixedJoint>();
							fj.connectedBody = _wall[xx,yy-1,zz].GetComponent<Rigidbody>();
							fj.breakForce = element_breakforce;
							fj.breakTorque = element_breaktorque;							
							
							if(xx>0) {
								FixedJoint fj2 = _wall[xx-1,yy,zz].AddComponent<FixedJoint>();
								fj2.connectedBody = _wall[xx,yy-1,zz].GetComponent<Rigidbody>();
								fj2.breakForce = element_breakforce;
								fj2.breakTorque = element_breaktorque;							
							}
						}
						if(zz>0) {
							FixedJoint fj = _wall[xx,yy,zz].AddComponent<FixedJoint>();
							fj.connectedBody = _wall[xx,yy,zz-1].GetComponent<Rigidbody>();
							fj.breakForce = element_breakforce;
							fj.breakTorque = element_breaktorque;							
						}
						
					}
				}
				if(((yy+1) % 2)==1) {
					current_offset = offset_per_Y_increment;
				}
				else
					current_offset = Vector3.zero;
				
			}
		}
	}
}
