namespace Exalgord{
    public class QuickSortRec{
		public void Sort(ref int[] info, int esq, int dir){
            if (esq < dir){
                int q = Partition(ref info, esq, dir);
                Sort(ref info, esq, q - 1);
                Sort(ref info, q + 1, dir);
            }
        }
        private static int Partition(ref int[] info, int esq, int dir){
            int aux = info[dir];
            int num;
            int i = esq;

            for (int j = esq; j < dir; ++j){
                if (info[j] <= aux){
                    num = info[j];
                    info[j] = info[i];
                    info[i] = num;
                    i++;
                }
            }
            info[dir] = info[i];
            info[i] = aux;

            return i;
        }
	}
}
