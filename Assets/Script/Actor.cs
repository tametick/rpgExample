using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour {
    public void Move(Vector3 target) {

    }

    public void TryToOpen(Treasure t) {
        t.TryToBeOpened(this);
    }
}
