namespace Plantilla_Admin.Tabs
{
    partial class FrUcMainAyuda
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Nodo0adsad");
            TreeNode treeNode2 = new TreeNode("Nodo1asdads");
            treeView1 = new TreeView();
            customRichTextBox1 = new Componentes.CustomRichTextBox();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.Black;
            treeView1.ForeColor = Color.White;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo0";
            treeNode1.Text = "Nodo0adsad";
            treeNode2.Name = "Nodo1";
            treeNode2.Text = "Nodo1asdads";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2 });
            treeView1.Size = new Size(488, 700);
            treeView1.TabIndex = 0;
            // 
            // customRichTextBox1
            // 
            customRichTextBox1.BackColor = Color.FromArgb(55, 60, 72);
            customRichTextBox1.BorderStyle = BorderStyle.None;
            customRichTextBox1.Font = new Font("Segoe UI", 10F);
            customRichTextBox1.ForeColor = Color.FromArgb(230, 230, 230);
            customRichTextBox1.Location = new Point(496, 0);
            customRichTextBox1.Margin = new Padding(5, 10, 5, 10);
            customRichTextBox1.MinimumSize = new Size(190, 60);
            customRichTextBox1.Name = "customRichTextBox1";
            customRichTextBox1.Size = new Size(554, 700);
            customRichTextBox1.TabIndex = 1;
            customRichTextBox1.Text = "";
            // 
            // FrUcMainAyuda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(customRichTextBox1);
            Controls.Add(treeView1);
            Margin = new Padding(0);
            Name = "FrUcMainAyuda";
            Size = new Size(1050, 700);
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private Componentes.CustomRichTextBox customRichTextBox1;
    }
}
