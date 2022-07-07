namespace Exalgord{
    public class QuickSortItr{
        public int[] Sort(int[] vector){
            int comeca = 0;
            int termina = vector.Length - 1;

            quickSort(vector, comeca, termina);

            return vector;
        }
        private static void quickSort(int[] vector, int comeca, int termina){
            if (comeca < termina){
                int p = vector[comeca];
                int i = comeca + 1;
                int f = termina;

                while (i <= f){
                    if (vector[i] <= p){
                        i++;
                    }
                    else if (p < vector[f]){
                        f--;
                    }
                    else{
                        int aux = vector[i];
                        vector[i] = vector[f];
                        vector[f] = aux;
                        i++;
                        f--;
                    }
                }
                vector[comeca] = vector[f];
                vector[f] = p;

                quickSort(vector, comeca, f - 1);
                quickSort(vector, f + 1, termina);
            }
        }
    }
}
