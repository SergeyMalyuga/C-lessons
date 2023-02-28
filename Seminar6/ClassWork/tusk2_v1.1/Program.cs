int n = 44;
void printBinary(int n)
{
    if (n==0) 
    return;
    printBinary(n/2);
    Console.Write (n%2);
}
printBinary(n);
