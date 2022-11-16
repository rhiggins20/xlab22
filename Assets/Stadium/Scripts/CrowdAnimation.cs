using UnityEngine;
using System.Collections;

public class CrowdAnimation : MonoBehaviour {
	public Texture2D[] textures;
	
	private int current;
	
	public float fps;
	
	// Use this for initialization
	void Start () {
		current = 0;
		
		StartCoroutine(UpdateAnimation());
	}
	
	IEnumerator UpdateAnimation () {
		while (true) {
			current++;
			
			if (current >= textures.Length)
				current = 0;
				
			GetComponent<Renderer>().sharedMaterial.SetTexture("_MainTexture", textures[current]);
			
			yield return new WaitForSeconds(1/fps);
		}
	}
}
