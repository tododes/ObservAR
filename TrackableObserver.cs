using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public interface TrackableObserver {
    void Observe();
    void OnTrackLost();
}
