using System.Collections.Generic;
using UnityEngine;

namespace Jettisoned
{
    //The object that "casts" the gravity
    public class OrbitController : MonoBehaviour
	//GravityManager???
    {
        [SerializeField] float gravity = -9.81f;
        [SerializeField] List<OrbitObject> orbitObjects;
        [SerializeField] OrbitObject[] debris;

        void Start()
        {
            //Find all orbital objects including the player and place into list
			foreach (var go in Resources.FindObjectsOfTypeAll<OrbitObject>())
			{
				orbitObjects.Add(go);
			}

            //Set objects into orbit based on their 
        }

        void Update()
        {

        }
    }

}