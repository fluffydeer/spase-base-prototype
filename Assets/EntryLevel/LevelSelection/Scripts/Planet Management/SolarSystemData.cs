using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SolarSystemData {

    public List<StarData> systems; // each star represents one solar system


    public SolarSystemData() {
        systems = new List<StarData>();
        systems.Add(new StarData());
        systems.Add(new StarData());
    }
}

[System.Serializable]
public class StarData {
    public string systemName = "name";
    public string systemDescription = "desc";
    public float starScale = 0.2f;
    public Vector3 orbitTilt = new Vector3(0,0,0); // in degrees
    public List<PlanetData> planets;

    public StarData() {
        planets = new List<PlanetData>();
        planets.Add(new PlanetData());
    }
}

[System.Serializable]
public class PlanetData {
    public string planetText = "text";
    public float angularSpeed = 60.0f;
    public float initialDegree = 0.0f;
    public float radius = 0.0f;
    public float planetScale = 0.3f; // scale is relative to the sun!
    public Vector3 orbitTilt = new Vector3(0, 0, 0); // in degrees
    public string sceneName = "scene"; // path relative to "Assets/Scenes/Levels/"; the global path prefix can be changed in 'SolarSystemGenerationManager' script
    public string texturePath = null; // path relative to "Assets/Resources/"; Unity uses / slash in path names
}
