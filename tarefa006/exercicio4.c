#include <stdio.h>

int main()
{
    int cod1, cod2, quant1, quant2, valor1, valor2;
    double IPI, total;
    
    printf("Digite a porcentagem do IPI: ");
    
    scanf("%lf", &IPI);
    
    printf("Digite o código da peça 1: ");
    
    scanf("%d", &cod1);
    
    printf("Digite o valor unitário da peça 1: ");
    
    scanf("%d", &valor1);
    
    printf("Digite a quantidade de peças 1: ");
    
    scanf("%d", &quant1);
    
    printf("Digite o código da peça 2: ");
    
    scanf("%d", &cod2);
    
    printf("Digite o valor unitário da peça 2: ");
    
    scanf("%d", &valor2);
    
    printf("Digite a quantidade de peças 2: ");
    
    scanf("%d", &quant2);
    
    total = (valor1 * quant1 + valor2 * quant2) * (IPI / 100 + 1);
    
    printf("O valor total é de: %lf", total);
    
    return 0;
}