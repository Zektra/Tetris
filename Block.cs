using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Block
{
    int WhichOne;

    public Block(int WhichOne)
    {
        this.WhichOne = WhichOne;
        CreateBlock();
    }

    public void CreateBlock()
    {
        bool[,] block = new bool[4, 4];
        switch (WhichOne)
        {
            //I-Shape
            case 0:
                block[1, 2] = true;
                block[2, 2] = true;
                block[3, 2] = true;
                block[4, 2] = true;
                break;

            /*case 1:
                break;

            case 2:
                break;

            case 3:
                break;

            case 4:
                break;

            case 5:
                break;

            case 6:
                break;*/
        }
        
    }
}
