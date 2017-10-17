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
			//O-Shape
            case 1:
				block[3, 1] = true;
				block[4, 1] = true;
				block[3, 2] = true;
				block[4, 2] = true;
                break;
			//T-Shape
            case 2:
				block[3, 1] = true;
				block[3, 2] = true;
				block[3, 3] = true;
				block[4, 2] = true;
                break;
			//S-Shape
            case 3:
				block[3, 3] = true;
				block[3, 2] = true;
				block[4, 2] = true;
				block[4, 1] = true;
                break;
			//Z-Shape
            case 4:
				block[3, 1] = true;
				block[3, 2] = true;
				block[4, 2] = true;
				block[4, 3] = true;
                break;
			//J-Shape
            case 5:
				block[2, 2] = true;
				block[3, 2] = true;
				block[4, 2] = true;
				block[4, 1] = true;
                break;
			//L-Shape
            case 6:
				block[2, 2] = true;
				block[3, 2] = true;
				block[4, 2] = true;
				block[4, 3] = true;
                break;
        }
        
    }
}
