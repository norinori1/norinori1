using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanagement : MonoBehaviour
{
    public List<int> BlockList = new List<int>(); // Generate Blocklist
    public List<int> DeleteList = new List<int>();// Generate DeleteList

    // Start is called before the first frame update
    public int line = 12;
    public int column = 13;

    public int Score;
    public int Combo;
    public int Level;
    void Start()
    {
        FillEmpty();

    }

    float delta = 0.03f;

    // Update is called once per frame
    void Update()
    {
        if (delta >= 0.03f)
        {
            Gravity();
            delta = 0;
        }
        else
        {
            delta += Time.deltaTime;
        }

    }

    void FillEmpty()
    {
        int LXC = line * column;
        for (int i = 0; i < LXC; i++)
        {
            BlockList.Add(0);
        }
    }


    private List<int> exception = new List<int>();
    void Gravity()
    {


        exception.Clear();
        for (int number = 0; number < BlockList.Count - line; number++)
        {
            if ((BlockList[number] != 0) && (BlockList[number + line] == 0))
            {
                if (!exception.Contains(number))
                {
                    int ReplaceAbove = BlockList[number];
                    int ReplaceUnder = BlockList[number + line];

                    BlockList[number + line] = ReplaceAbove;
                    BlockList[number] = ReplaceUnder;
                    exception.Add(number + line);
                }
            }
        }

        // wait 0.1 seconds

    }
}
