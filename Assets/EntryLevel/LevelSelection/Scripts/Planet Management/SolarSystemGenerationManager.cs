using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;

public class SolarSystemGenerationManager : MonoBehaviour {
    public enum ChangeDirection { Previous, Next };
    public TextAsset solarSystemJSON = null;

    public GameObject sunPrefab = null;
    public GameObject planetPrefab = null;
    public SnapDropPlanet snapDropRef = null; // reference to the dropzone, that the planets need to call
    public Light dropzoneSpotlightRef = null; // reference to the light at the dropzone
    public Text systemTitleReference = null;
    public Text systemDescriptionReference = null;
    private SolarSystemData systemsData;
    private int currentSolarSystem = 0;
    private List<GameObject> generatedSystems = null;

    private const string SCENE_PATH_PREFIX = "Scenes/Levels/";

    void Awake() {

        Debug.Log("Awake");

        if(this.solarSystemJSON != null) {
            // parse the JSON
            systemsData = JsonUtility.FromJson<SolarSystemData>(this.solarSystemJSON.text);

            // generate the solar systems
            if (systemsData != null) { 
                this.generateSolarSystems();
            }

            //systemsData = new SolarSystemData();

            //Debug.Log(JsonUtility.ToJson(systemsData));
        }
        else {
            throw new System.Exception("Input file for 'SolarSystemGenerationManager' is not set!");
        }
    }

    private void generateSolarSystems() {
        // check existance of prefabs
        if(this.sunPrefab == null) {
            throw new System.Exception("Sun prefab for 'SolarSystemGenerationManager' is not set!");
        }
        if(this.planetPrefab == null) {
            throw new System.Exception("Planet prefab for 'SolarSystemGenerationManager' is not set!");
        }
        // check existance of references
        if(this.snapDropRef == null) {
            throw new System.Exception("'SolarSystemGenerationManager' does not have a reference to the SnapDropPlanet Object");
        }
        if(this.dropzoneSpotlightRef == null) {
            throw new System.Exception("'SolarSystemGenerationManager' does not have a reference to the Light Object at the dropzone");
        }

        // initialise the list (stores all the Stars)
        this.generatedSystems = new List<GameObject>();
        
        // enable only the first solar system
        bool first = true;

        // create solar systems
        foreach (StarData star in this.systemsData.systems) {
            // create star from prefab
            GameObject starObj = Instantiate(this.sunPrefab, this.transform, false);

            // set custom scale
            starObj.transform.localScale = new Vector3(star.starScale, star.starScale, star.starScale);

            // change the orbit tilt
            Sun s = starObj.GetComponent<Sun>();
            if(s != null) {
                s.globalOrbitTiltDeg = star.orbitTilt;
            }
            else {
                throw new System.Exception("Sun Object generated from prefab doesn't contain a Sun script component");
            }

            // add to the list of stars so we don't loose the reference
            this.generatedSystems.Add(starObj);

            // calculate the global rotation Quaternion only once for reuse
            Quaternion globalTiltQ = Quaternion.Euler(star.orbitTilt);

            // disable the star if it isn't the first one
            if (!first)
            {
                // every other star
                starObj.SetActive(false);
            }
            else
            {
                // first star
                first = false;
                systemTitleReference.text = star.systemName;
                systemDescriptionReference.text = star.systemDescription;
            }

            // create the planets
            foreach (PlanetData planet in star.planets) {
                // calculate the initial position of the planet on its orbit
                Vector3 offset = new Vector3(planet.radius, 0.0f, 0.0f);
                // offset the default starting position by the given angle
                offset = Quaternion.Euler(0.0f, planet.initialDegree, 0.0f) * offset;
                // apply global orbit tilt from the sun
                offset = globalTiltQ * offset;
                // apply planets own orbit tilt
                offset = Quaternion.Euler(planet.orbitTilt) * offset;

                // create planet from prefab
                GameObject planetObj = Instantiate(this.planetPrefab, starObj.transform.position + offset, Quaternion.identity, starObj.transform);

                // set custom scale
                planetObj.transform.localScale = new Vector3(planet.planetScale, planet.planetScale, planet.planetScale);

                // set parameters of OrbitSun component
                OrbitSun os = planetObj.GetComponent<OrbitSun>();
                if(os != null) {
                    os.sun = s; // assign the correct star as this planets sun; 's' is the Sun component of 'starObj'
                    os.angularSpeedDeg = planet.angularSpeed;
                    os.angleOffsetDeg = planet.initialDegree;
                    os.orbitTiltDeg = planet.orbitTilt;
                }
                else {
                    throw new System.Exception("Planet Object generated from prefab doesn't contain an OrbitSun script component");
                }

                // add the call to the dropzone on the OnDetach listener in the Throwable component
                Throwable t = planetObj.GetComponent<Throwable>();
                if(t != null) {
                 //   UnityEditor.Events.UnityEventTools.AddPersistentListener(t.onDetachFromHand, this.snapDropRef.checkPlanetDrop);
                }
                else {
                    throw new System.Exception("Planet Object generated from prefab doesn't contain a Throwable component");
                }

                // set the parameters of the Planet component
                Planet p = planetObj.GetComponent<Planet>();
                if(p != null) {
                    p.indicatorLight = this.dropzoneSpotlightRef;
                    p.sceneName = SCENE_PATH_PREFIX + planet.sceneName;
                }
                else {
                    throw new System.Exception("Planet Object generated from prefab doesn't contain a Planet component");
                }

                // set the parameters of the DisplayUI component
                DisplayUI dui = planetObj.GetComponent<DisplayUI>();
                if(dui != null) {
                    dui.textToBeShown = planet.planetText;
                }
                else {
                    throw new System.Exception("Planet Object generated from prefab doesn't contain a DisplayUI component");
                }

                // set the custom texture (if one is needed)
                if(planet.texturePath != null) {
                    // try to load the texture from the Resource folder
                    Texture2D texture = Resources.Load<Texture2D>(planet.texturePath);

                    if(texture == null) {
                        throw new System.Exception("Specified Texture for the Planet Object could not be loaded");
                    }

                    // set the texture to the material
                    Renderer r = planetObj.GetComponent<Renderer>();
                    if(r != null) {
                        r.material.SetTexture("_MainTex", texture);
                    }
                    else {
                        throw new System.Exception("Planet Object generated from prefab doesn't contain a Renderer component");
                    }
                }
            }
        }
    }

    //Changes the active solar system into the next or previous system in the list
    public void ChangeActiveSolarSystem(ChangeDirection cd)
    {
        // deactivate current system
        generatedSystems[currentSolarSystem].SetActive(false);
        // change current system based on input
        if (cd == ChangeDirection.Previous)
        {
            currentSolarSystem -= 1;
            if (currentSolarSystem < 0)
            {
                currentSolarSystem = generatedSystems.Count - 1;
            }
        }
        else if (cd == ChangeDirection.Next)
        {
            currentSolarSystem += 1;
            if (currentSolarSystem >= generatedSystems.Count)
            {
                currentSolarSystem = 0;
            }
        }
        // activate new current system
        generatedSystems[currentSolarSystem].SetActive(true);
        systemTitleReference.text = systemsData.systems[currentSolarSystem].systemName;
        systemDescriptionReference.text = systemsData.systems[currentSolarSystem].systemDescription;
    }
}
