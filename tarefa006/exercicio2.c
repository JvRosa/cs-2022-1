#include <stdio.h>

int main()
{
    int media1, media2, somedia, memedia;
    
    media1 = (8 + 9 + 7)/3;
    media2 = (4 + 5 + 6)/3;
    somedia = media1 + media2;
    memedia = somedia/2;
    
    printf("Média aritmética de 8, 9 e 7: %d\n", media1);
    printf("Média aritmética de 4, 5 e 6: %d\n", media2);
    printf("Soma das médias aritméticas de 8, 9, 7 e de 4, 5, 6: %d\n", somedia);
    printf("Média das médias aritméticas de 8, 9, 7 e de 4, 5, 6: %d\n", memedia);
    
    return 0;
}
