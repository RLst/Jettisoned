using UnityEngine;

public class OrbitPrimary : MonoBehaviour {

	// [SerializeField] float gravity = 9.81f;
	public float Gravity { get; private set; }

	void Start()
	{
		Gravity = 9.81f;
	}
}

