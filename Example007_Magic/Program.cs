﻿Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");
int xa=30;
int ya=1;
int xb=1, yb=15,
    xc=60, yc=15;
Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int  x = xa, y = xb;

int count=0;

while ( count < 10 );
{
    int rand = new Random().Next(0,3); //0,1,2
    if (rand==0)
    {
        x=(x+xa)/2;
        y=(y+ya)/2;
    }
    if (rand==1)
    {
        x=(x+xb)/2;
        y=(y+yb)/2;
    }
    if (rand==2)
    {
        x=(x+xc)/2;
        y=(y+yc)/2;
    }
    
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    //Console.WriteLine(count);
    //Console.WriteLine(rand);
    count = count + 1;

        
}