using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
	[SerializeField] GameObject wall;
	[SerializeField, Header("マップサイズ")] Vector2Int mapSize;
	// Start is called before the first frame update
	void Start()
    {
		MapFrame();
    }

	void MapFrame()
	{
		for (int i = 0; i < mapSize.x; i++)
		{
			for (int j = 0; j < mapSize.y; j++)
			{
				if (i==0||j==0)
				{
					Instantiate(wall, new Vector3(i, 0, j), Quaternion.identity);
				}

				else if (i==mapSize.x-1||j==mapSize.y-1)
				{
					Instantiate(wall, new Vector3(i, 0, j), Quaternion.identity);
				}
			}
		}
	}
}
