#include <stdio.h>

int main()
{
    int num, aux;
    
    printf("Digite um número inteiro: ");
    
    scanf("%d", &num);
    
    aux = num - 1;
    
    printf("O antecessor do número é: %d\n", aux);
    
    aux = num + 1;
    
    printf("O sucessor do número é: %d", aux);

    return 0;
}
