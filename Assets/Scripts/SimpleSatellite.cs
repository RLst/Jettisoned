using UnityEngine;

public class SimpleSatellite : MonoBehaviour
//This object orbits around the primary VERY SIMPLY
{
	[SerializeField] Transform orbitalPrimary;

	void Start()
	{
		orbitalPrimary = FindObjectOfType<OrbitPrimary>().transform;
	}

	void Update()
	{
		transform.RotateAround()
	}
}
