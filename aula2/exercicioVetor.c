#include <stdio.h>
#include <stdlib.h>

int main() {
  int valor = 0;
  printf("Entre o tamanho do vetor: ");
  scanf("%d", &valor);

  int vetor[valor];

  int auxInsert;
  for (int i = 0; i < (sizeof(vetor) / 4); i++) {
    auxInsert = rand();
    if (i > 0) {
      if (auxInsert = vetor[i]) {
        vetor[i] = rand();
      } else {
        vetor[i] = auxInsert;
      }
    } else {
      vetor[i] = rand();
    }
    printf("%d \n", vetor[i]);
  }

  printf("Ordenados do menor para o maior: \n");

  int vetAux[sizeof(vetor)];
  int aux = vetor[0];
  int vetSub;

  for (int k = 0; k < (sizeof(vetor) / 4); k++) {
    for (int j = 0; j < (sizeof(vetor) / 4); j++) {
      if (vetor[j] > vetor[j + 1]) {
        aux = vetor[j];
        vetor[j] = vetor[j + 1];
        vetor[j + 1] = aux;
      }
    }
  }

  int l = 0;
  while (l < sizeof(vetor) / 4) {
    printf("%d\n", vetor[l]);
    l++;
  }
}