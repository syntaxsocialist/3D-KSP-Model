using UnityEngine;

namespace ParamExtract
{
    [KSPAddon(KSPAddon.Startup.TrackingStation, false)]
    public class ParamExtract : MonoBehaviour
    {
        public void Start()
        {
            // fires when focus changed in tracking station
            GameEvents.onPlanetariumTargetChanged.Add(TrackingStationTargetChanged);
        }

        // React to tracking station focus changing
        private void TrackingStationTargetChanged(MapObject target)
        {
            Debug.Log("Name: " + target.name);
            Debug.Log("Radius: " + target.celestialBody.Radius);
            Debug.Log("SMA: " + target.orbit.semiMajorAxis);
            Debug.Log("Eccentricity: " + target.orbit.eccentricity);
            Debug.Log("Inclination: " + target.orbit.inclination);
            Debug.Log("LAN: " + target.orbit.LAN);
            Debug.Log("APe: " + target.orbit.argumentOfPeriapsis);
            Debug.Log("Period: " + target.orbit.period);
            Debug.Log("Mean Motion: " + target.orbit.meanMotion);
            Debug.Log("Pe Radius: " + target.orbit.PeR);
            Debug.Log("Ap Radius: " + target.orbit.ApR);
            Debug.Log("Epoch: " + target.orbit.epoch);
            Debug.Log("MNA at UT=0: " + target.orbit.meanAnomalyAtEpoch);
            Debug.Log("SOI Radius: " + target.celestialBody.sphereOfInfluence);
            Debug.Log("Atmo Alt: " + target.celestialBody.atmosphereDepth);
        }
    }
}