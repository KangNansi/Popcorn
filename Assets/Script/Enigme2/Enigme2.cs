using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enigme2 : State {

    
    List<int> path;
    int ox;
    int oy;
    int fx;
    int fy;

	// Use this for initialization
	void Start () {
        path = new List<int>();
        fx = ox = Random.Range(0, 6);
        fy = oy = Random.Range(0, 4);
        for(int i=0; i<5; i++)
        {
            int dir = Random.Range(0, 4);
            switch (dir)
            {
                case 0:
                    if (fy - 1 < 0)
                    {
                        i--;
                        continue;
                    }
                    fy--;
                    path.Add(dir);
                    break;

                case 1:
                    if (fy + 1 >= 4)
                    {
                        i--;
                        continue;
                    }
                    fy++;
                    path.Add(dir);
                    break;

                case 2:
                    if (fx - 1 < 0)
                    {
                        i--;
                        continue;
                    }
                    fx++;
                    path.Add(dir);
                    break;

                case 3:
                    if (fx + 1 >= 6)
                    {
                        i--;
                        continue;
                    }
                    fx++;
                    path.Add(dir);
                    break;
            }
        }



    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Clicked(int x, int y)
    {
        if (x == fx && y == fy)
            state = 1;
    }
}
