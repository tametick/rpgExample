using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour {
    public GameObject contentPrefab;
    float difficulty;

    public void TryToBeOpened(Actor opener) {
        //... difficulty vs opener.skill??
        // if(success)
        //     Open();
    }

    public void Open() {
        var content = Instantiate(contentPrefab);
        content.transform.position = new Vector3(transform.position.x, content.transform.position.y, transform.position.z);
    }
}
