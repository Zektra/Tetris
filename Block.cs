using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Block
{
    int WhichOne = 0;

    public Block(int WhichOne)
    {
        this.WhichOne = WhichOne;
        CreateBlock();
    }

    public bool[,] CreateBlock()
    {
		bool[,] block = new bool[4, 4];
        switch (WhichOne)
        {
            //I-Shape
            case 0:
                block[0, 1] = true;
                block[1, 1] = true;
                block[2, 1] = true;
                block[3, 1] = true;
                break;
			//O-Shape
            case 1:
				block[2, 0] = true;
				block[3, 0] = true;
				block[2, 1] = true;
				block[3, 1] = true;
                break;
			//T-Shape
            case 2:
				block[2, 0] = true;
				block[2, 1] = true;
				block[2, 2] = true;
				block[3, 1] = true;
                break;
			//S-Shape
            case 3:
				block[2, 2] = true;
				block[2, 1] = true;
				block[3, 1] = true;
				block[3, 0] = true;
                break;
			//Z-Shape
            case 4:
				block[2, 0] = true;
				block[2, 1] = true;
				block[3, 1] = true;
				block[3, 2] = true;
                break;
			//J-Shape
            case 5:
				block[1, 1] = true;
				block[2, 1] = true;
				block[3, 1] = true;
				block[3, 0] = true;
                break;
			//L-Shape
            case 6:
				block[1, 1] = true;
				block[2, 1] = true;
				block[3, 1] = true;
				block[3, 2] = true;
                break;
        }
		return block;
    }
}
