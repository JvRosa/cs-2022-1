#include <stdio.h>

int main()
{
    int anos, meses, dias, idade;
    
    printf("Digite a idade em anos, meses e dias: ");
    
    scanf("%d" "%d" "%d", &anos, &meses, &dias);
    
    idade = ((anos*365) + (meses*30)) + dias;
    
    printf("idade é igual a %d dias", idade);

    return 0;
}
