package proyecto1;

import Logica.AlgoritmosOrdenamiento;

public class frmMergeSort extends javax.swing.JFrame {

    AlgoritmosOrdenamiento algoritmos = new AlgoritmosOrdenamiento();

    public frmMergeSort() {
        initComponents();

        this.displayArray(false);
        this.algoritmos.mergeSort();
        this.displayArray(true);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        Ordenado = new javax.swing.JTextArea();
        jScrollPane2 = new javax.swing.JScrollPane();
        Desordenado = new javax.swing.JTextArea();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        Ordenado.setColumns(20);
        Ordenado.setRows(5);
        jScrollPane1.setViewportView(Ordenado);

        Desordenado.setColumns(20);
        Desordenado.setRows(5);
        jScrollPane2.setViewportView(Desordenado);

        jLabel1.setText("Desordenado");

        jLabel2.setText("Ordenado");

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 455, Short.MAX_VALUE)
                        .addComponent(jScrollPane2))
                    .addComponent(jLabel1)
                    .addComponent(jLabel2))
                .addContainerGap(25, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(13, 13, 13)
                .addComponent(jLabel2)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 105, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(13, 13, 13)
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(23, Short.MAX_VALUE))
        );

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 490, 300));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void displayArray(boolean isOrdenado) {
        try {
            int[] array = this.algoritmos.getArregloMergeSort();
            String data = "";

            if (array.length > 0) {

                int x = 0;

                for (int i = 0; i < array.length; i++) {

                    if (x == 4) {
                        data += array[i] + "\n";
                        x = 0;
                    } else {
                        data += array[i] + " -> ";
                    }

                    x++;
                }

                if (isOrdenado) {
                    this.Ordenado.append(data);
                } else {
                    this.Desordenado.append(data);
                }
            }
        } catch (Exception ex) {

        }
    }

    public static void main(String args[]) {

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new frmMergeSort().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTextArea Desordenado;
    private javax.swing.JTextArea Ordenado;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    // End of variables declaration//GEN-END:variables
}
