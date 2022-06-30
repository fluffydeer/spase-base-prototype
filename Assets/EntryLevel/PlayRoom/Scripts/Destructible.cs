// --------------------------------------
// This script is totally optional. It is an example of how you can use the
// destructible versions of the objects as demonstrated in my tutorial.
// Watch the tutorial over at http://youtube.com/brackeys/.
// --------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

	public GameObject destroyedVersion;	// Reference to the shattered version of the object
    public GameObject oldVersion;
    private Vector3 originalPosition;
    private Quaternion originalRotation;

    // If the player clicks on the object
    public void Destroy ()
	{
		// Spawn a shattered object
		Instantiate(destroyedVersion, transform.position, transform.rotation);
		// Remove the current object
		Destroy(gameObject);
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "OurGranade_1")
        {
            originalPosition = oldVersion.transform.position;
            originalRotation = oldVersion.transform.rotation;
            destroyedVersion.transform.SetPositionAndRotation(originalPosition, originalRotation);
            destroyedVersion.SetActive(true);
            oldVersion.SetActive(false);
        }

        if (col.gameObject.name == "OurGranade_2")
        {
            originalPosition = oldVersion.transform.position;
            originalRotation = oldVersion.transform.rotation;
            destroyedVersion.transform.SetPositionAndRotation(originalPosition, originalRotation);
            destroyedVersion.SetActive(true);
            oldVersion.SetActive(false);
        }

        if (col.gameObject.name == "OurGranade_3")
        {
            originalPosition = oldVersion.transform.position;
            originalRotation = oldVersion.transform.rotation;
            destroyedVersion.transform.SetPositionAndRotation(originalPosition, originalRotation);
            destroyedVersion.SetActive(true);
            oldVersion.SetActive(false);
        }

        if (col.gameObject.name == "OurGranade_4")
        {
            originalPosition = oldVersion.transform.position;
            originalRotation = oldVersion.transform.rotation;
            destroyedVersion.transform.SetPositionAndRotation(originalPosition, originalRotation);
            destroyedVersion.SetActive(true);
            oldVersion.SetActive(false);
        }

        if (col.gameObject.name == "OurGranade_5")
        {
            originalPosition = oldVersion.transform.position;
            originalRotation = oldVersion.transform.rotation;
            destroyedVersion.transform.SetPositionAndRotation(originalPosition, originalRotation);
            destroyedVersion.SetActive(true);
            oldVersion.SetActive(false);
        }

        if (col.gameObject.name == "OurGranade_6")
        {
            originalPosition = oldVersion.transform.position;
            originalRotation = oldVersion.transform.rotation;
            destroyedVersion.transform.SetPositionAndRotation(originalPosition, originalRotation);
            destroyedVersion.SetActive(true);
            oldVersion.SetActive(false);
        }

        if (col.gameObject.name == "OurGranade_7")
        {
            originalPosition = oldVersion.transform.position;
            originalRotation = oldVersion.transform.rotation;
            destroyedVersion.transform.SetPositionAndRotation(originalPosition, originalRotation);
            destroyedVersion.SetActive(true);
            oldVersion.SetActive(false);
        }

        if (col.gameObject.name == "Bow Arrow")
        {
            originalPosition = oldVersion.transform.position;
            originalRotation = oldVersion.transform.rotation;
            destroyedVersion.transform.SetPositionAndRotation(originalPosition, originalRotation);
            destroyedVersion.SetActive(true);
            oldVersion.SetActive(false);
        }
    }

}
