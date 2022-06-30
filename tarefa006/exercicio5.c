#include <stdio.h>

int main()
{
    double salario, nsal;
    double salmin = 1045;
    
    printf("Digite o valor do salário: ");
    
    scanf("%lf", &salario);
    
    nsal = salario / salmin;
    
    printf("O usuário ganha %0.2lf salários mínimos", nsal);

    return 0;
}
