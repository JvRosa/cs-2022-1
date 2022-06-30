#include <stdio.h>

int main()
{
    double saldo, novosaldo;
    
    printf("Digite o valor do saldo: ");
    
    scanf("%lf", &saldo);
    
    novosaldo = saldo*1.15;
    
    printf("O valor do saldo reajustado é de: %0.2lf", novosaldo);

    return 0;
}
