namespace MyMemoryManager {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel = new Panel();
            label2 = new Label();
            Potion = new Label();
            Inventory = new PictureBox();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Inventory).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.AllowDrop = true;
            panel.Controls.Add(label2);
            panel.Controls.Add(Potion);
            panel.Controls.Add(Inventory);
            panel.Location = new Point(12, 12);
            panel.Name = "panel";
            panel.Size = new Size(776, 361);
            panel.TabIndex = 0;
            panel.Paint += panelItems_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 101);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "label2";
            label2.Click += label2_Click;
            label2.MouseDown += DragStart;
            label2.MouseMove += Dragging;
            label2.MouseUp += DragEnd;
            // 
            // Potion
            // 
            Potion.AutoSize = true;
            Potion.Location = new Point(35, 28);
            Potion.Name = "Potion";
            Potion.Size = new Size(54, 20);
            Potion.TabIndex = 4;
            Potion.Text = "Potion";
            Potion.MouseDown += DragStart;
            Potion.MouseMove += Dragging;
            Potion.MouseUp += DragEnd;
            // 
            // Inventory
            // 
            Inventory.Image = Properties.Resources.빈티지_가죽_여행용_백팩;
            Inventory.Location = new Point(394, 0);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(382, 358);
            Inventory.SizeMode = PictureBoxSizeMode.Zoom;
            Inventory.TabIndex = 1;
            Inventory.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel);
            Name = "Form1";
            Text = "Form1";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Inventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Label label2;
        private Label Potion;
        private PictureBox Inventory;
    }
}
