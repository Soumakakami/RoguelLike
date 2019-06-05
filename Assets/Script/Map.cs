using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
	[SerializeField] GameObject wall;
	[SerializeField, Header("マップサイズ")] Vector2Int mapSize;
	[SerializeField, Header("部屋の最小値")] Vector2Int minRoomSize;

	int[,] mapDate;

	// Start is called before the first frame update
	void Start()
	{
		mapDate = new int[mapSize.x, mapSize.y];
		MapFrame();

	}

	public struct Room
	{
		public Vector2Int roomSize;		//部屋の左下の頂点座標
		public int width;				//横幅
		public int height;				//縦幅
	}

	void MapFrame()
	{
		for (int i = 0; i < mapSize.x; i++)
		{
			for (int j = 0; j < mapSize.y; j++)
			{
				if (i == 0 || j == 0)
				{
					Instantiate(wall, new Vector3(i, 0, j), Quaternion.identity);
					mapDate[i, j] = 1;
				}

				else if (i == mapSize.x - 1 || j == mapSize.y - 1)
				{
					Instantiate(wall, new Vector3(i, 0, j), Quaternion.identity);
					mapDate[i, j] = 1;
				}
			}
		}

		for (int i = 0; i < mapSize.x; i++)
		{

		}
	}
}
