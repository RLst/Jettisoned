using UnityEngine;

namespace Jettisoned
{
    public enum Atmosphere
    {


    }

    public class OrbitObject : MonoBehaviour
    {
        [SerializeField] float mass;
        [SerializeField] OrbitPrimary orbitPrimary;
        float distanceFromPrimary;
        float workingGravity;

        void Start()
        {     
            //Find earth
            orbitPrimary = FindObjectOfType<OrbitPrimary>();



            //Set in motion
        }

        void FixedUpdate()
        {
            //Continually apply gravity
        }
        void Update()
        {
            //Continually orbit
        }

        public void Orbit(Transform orbitTarget)
        {

        }
    }

}