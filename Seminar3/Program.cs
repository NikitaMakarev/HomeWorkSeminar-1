
int FindQuart(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    
    return -1;
}

int result = FindQuart(2,4);

if(result == -1) Console.WritLeline("Данная точка расположена на осях");
else Console.WritLeline($"Точка находится в (result) четверти");