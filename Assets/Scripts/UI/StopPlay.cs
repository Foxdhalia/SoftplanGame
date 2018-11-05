using UnityEngine;

public class StopPlay : MonoBehaviour {
    public Manager manager;

	// Use this for initialization
	void Start () {
        manager.StopPlayerControlls(true);
	}
}
