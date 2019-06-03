using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
	[SerializeField] GameObject wall;
	int  a=1;
	// Start is called before the first frame update
	void Start()
    {
		test(a);
		Debug.Log(a);
    }

	void test(in int _test)
	{
		Debug.Log(_test);
	}
}
