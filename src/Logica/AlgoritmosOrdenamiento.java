package Logica;

import java.util.ArrayList;
import java.util.List;

public class AlgoritmosOrdenamiento {

    private static int[] arregloBurbuja = new int[2000];
    private static long tiempoEjecucionBurbuja = 0;

    private static int[] arregloInsercion = new int[2000];
    private static long tiempoEjecucionInsercion = 0;

    private static int[] arregloMergeSort = new int[2000];
    private static long tiempoEjecucionMergeSort = 0;

    private static int[] arregloQuickSort = new int[2000];
    private static long tiempoEjecucionQuickSort = 0;

    //METODO PARA LLENAR LOS ARREGLOS
    public void fill() {
        try {

            for (int i = 0; i < 2000; i++) {
                arregloBurbuja[i] = (int) (Math.random() * 2000);
            }

            for (int i = 0; i < 2000; i++) {
                arregloQuickSort[i] = (int) (Math.random() * 2000);
            }

            for (int i = 0; i < 2000; i++) {
                arregloMergeSort[i] = (int) (Math.random() * 2000);
            }

            for (int i = 0; i < 2000; i++) {
                arregloInsercion[i] = (int) (Math.random() * 2000);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
    }

    //OFRDENA UN ARREGLO MEDIANTE EL ALGORITMO BUBUJA
    public void burbuja() {
        try {

            long inicio = System.currentTimeMillis();

            for (int i = 0; i < arregloBurbuja.length; i++) {
                for (int j = 0; j < arregloBurbuja.length - 1; j++) {
                    if (arregloBurbuja[j] > arregloBurbuja[j + 1]) {
                        int aux = arregloBurbuja[j];
                        arregloBurbuja[j] = arregloBurbuja[j + 1];
                        arregloBurbuja[j + 1] = aux;
                    }
                }
            }

            long fin = System.currentTimeMillis();

            tiempoEjecucionBurbuja = fin - inicio;

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
    }

    //ORDENA UN ARREGLO MEDIANTE EL ALGORITMO MERGE SORT
    public void mergeSort() {
        try {
            long inicio = System.currentTimeMillis();

            arregloMergeSort = merge(arregloMergeSort);
            
            long fin = System.currentTimeMillis();

            tiempoEjecucionMergeSort = fin - inicio;

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
    }

    public int[] merge(int arreglo[]) {
        try {
            int i, j, k;

            if (arreglo.length > 1) {
                int nElementosIzq = arreglo.length / 2;
                int nElementosDer = arreglo.length - nElementosIzq;
                int arregloIzq[] = new int[nElementosIzq];
                int arregloDer[] = new int[nElementosDer];

                for (i = 0; i < nElementosIzq; i++) {
                    arregloIzq[i] = arreglo[i];
                }

                for (i = nElementosIzq; i < nElementosIzq + nElementosDer; i++) {
                    arregloDer[i - nElementosIzq] = arreglo[i];
                }

                arregloIzq = merge(arregloIzq);
                arregloDer = merge(arregloDer);

                i = 0;
                j = 0;
                k = 0;

                while (arregloIzq.length != j && arregloDer.length != k) {
                    if (arregloIzq[j] < arregloDer[k]) {
                        arreglo[i] = arregloIzq[j];
                        i++;
                        j++;
                    } else {
                        arreglo[i] = arregloDer[k];
                        i++;
                        k++;
                    }
                }

                while (arregloIzq.length != j) {
                    arreglo[i] = arregloIzq[j];
                    i++;
                    j++;
                }

                while (arregloDer.length != k) {
                    arreglo[i] = arregloDer[k];
                    i++;
                    k++;
                }
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
         return arreglo;
    }

    public void quick() {
        long inicio = System.currentTimeMillis();
        quickSort(0, 1999);
        long fin = System.currentTimeMillis();

        tiempoEjecucionQuickSort = fin - inicio;
    }

    //ORDENA UN ARREGLO MEDIANTE EL ALGORITMO QUICK SORT
    public void quickSort(int primero, int ultimo) {
        try {
            int i = primero, j = ultimo, pivote, aux;
            pivote = arregloQuickSort[(primero + ultimo) / 2];

            do {
                while (arregloQuickSort[i] < pivote) {
                    i++;
                }

                while (arregloQuickSort[j] > pivote) {
                    j--;
                }

                if (i <= j) {
                    aux = arregloQuickSort[i];
                    arregloQuickSort[i] = arregloQuickSort[j];
                    arregloQuickSort[j] = aux;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j) {
                quickSort(primero, j);
            }

            if (i < ultimo) {
                quickSort(i, ultimo);
            }

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
    }

    //ORDENA UN ARREGLO MEDIANTE EL ALGORITMO DE INSERCION
    public void insercion() {
        try {

            long inicio = System.currentTimeMillis();

            int p, j;
            int aux;
            for (p = 1; p < arregloInsercion.length; p++) {
                aux = arregloInsercion[p];
                j = p - 1;
                while ((j >= 0) && (aux < arregloInsercion[j])) {
                    arregloInsercion[j + 1] = arregloInsercion[j];
                    j--;
                }
                arregloInsercion[j + 1] = aux;
            }

            long fin = System.currentTimeMillis();

            tiempoEjecucionInsercion = fin - inicio;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
    }

    //METODO PARA MOSTRAR LOS TIEMPOS Y EL NOMBRE DEL ALGORITMO
    public List<Tiempos> getTiempos() {
        List<Tiempos> list = new ArrayList();
        try {
            Tiempos tempoBurbuja = new Tiempos();
            tempoBurbuja.setAlgoritmo("Burbuja");
            tempoBurbuja.setTiempo(tiempoEjecucionBurbuja);

            Tiempos tempoInsercion = new Tiempos();
            tempoInsercion.setAlgoritmo("Inserción");
            tempoInsercion.setTiempo(tiempoEjecucionInsercion);

            Tiempos tempoQuick = new Tiempos();
            tempoQuick.setAlgoritmo("QuickSort");
            tempoQuick.setTiempo(tiempoEjecucionQuickSort);

            Tiempos tempoMerge = new Tiempos();
            tempoMerge.setAlgoritmo("MergeSort");
            tempoMerge.setTiempo(tiempoEjecucionMergeSort);

            list.add(tempoBurbuja);
            list.add(tempoInsercion);
            list.add(tempoQuick);
            list.add(tempoMerge);

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return list;
    }

    public int[] getArregloBurbuja() {
        return arregloBurbuja;
    }

    public int[] getArregloInsercion() {
        return arregloInsercion;
    }

    public int[] getArregloMergeSort() {
        return arregloMergeSort;
    }

    public int[] getArregloQuickSort() {
        return arregloQuickSort;
    }

}
