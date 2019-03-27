using UnityEngine;

public class Main : MonoBehaviour {

    private GameObject cube1;
    private GameObject cube2;
	// Use this for initialization
	void Start () {
        cube1 = GameObject.Find("Cube1");
        cube2 = GameObject.Find("Cube2");
        //pass C#'s delegate to C++
        DllInterface.InitCSharpDelegate(DllInterface.LogMessageFromCpp);
        PrintDistanceViaUnity();
    }
	
	void PrintDistanceViaUnity()
    {
        var pos1 = cube1.transform.position;
        var pos2 = cube2.transform.position;
        Debug.Log("This is a log from Unity");
        Debug.Log("Distance:" + DllInterface.GetDistance(pos1.x, pos1.y, pos2.x, pos2.y));
    }
}
