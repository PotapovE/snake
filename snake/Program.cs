int x1 = 1;
int y1 = 3;
char sym1 = '*';

void Draw(int x, int y, char sym)
{
    Console.SetCursorPosition(x, y);
    Console.Write(sym);
}

Draw(x1, y1, sym1);

Console.ReadLine();