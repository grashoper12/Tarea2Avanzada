
package proyecto1;

import Logica.AlgoritmosOrdenamiento;


public class frmInsercion extends javax.swing.JFrame {

    AlgoritmosOrdenamiento algoritmos = new AlgoritmosOrdenamiento();
    
    public frmInsercion() {
        initComponents();
        
        this.displayArray(false);
        this.algoritmos.insercion();
        this.displayArray(true);
    }

   
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        desordenado = new javax.swing.JTextArea();
        jScrollPane2 = new javax.swing.JScrollPane();
        ordenado = new javax.swing.JTextArea();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        desordenado.setColumns(20);
        desordenado.setRows(5);
        jScrollPane1.setViewportView(desordenado);

        ordenado.setColumns(20);
        ordenado.setRows(5);
        jScrollPane2.setViewportView(ordenado);

        jLabel1.setText("Ordenados");

        jLabel2.setText("Desordenados");

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 400, Short.MAX_VALUE)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel1)
                            .addComponent(jLabel2))
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel1Layout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 400, Short.MAX_VALUE)
                    .addContainerGap()))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 139, Short.MAX_VALUE)
                .addComponent(jLabel2)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 121, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(35, 35, 35))
            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel1Layout.createSequentialGroup()
                    .addGap(35, 35, 35)
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 121, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(184, Short.MAX_VALUE)))
        );

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 420, 340));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void displayArray(boolean isOrdenado){
        try{
            int[] array = this.algoritmos.getArregloInsercion();
            String data = "";
            
            if(array.length > 0){
                
                int x = 0;
                
                for(int i = 0; i < array.length; i++){
                    
                    if(x == 4){
                        data += array[i]+"\n";
                        x = 0;
                    }else{
                        data += array[i]+" -> ";
                    }
                    
                    x++;
                }
                
                if(isOrdenado){
                    this.ordenado.append(data);
                }else{
                    this.desordenado.append(data);
                }
            }
        }catch(Exception ex){
            
        }
    }
  
    public static void main(String args[]) {
       
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new frmInsercion().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTextArea desordenado;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTextArea ordenado;
    // End of variables declaration//GEN-END:variables
}
