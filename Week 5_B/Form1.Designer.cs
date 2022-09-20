namespace Week_5_B
{
    partial class Matrices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leer = new System.Windows.Forms.Button();
            this.leerArchivo = new System.Windows.Forms.OpenFileDialog();
            this.listMaxBox = new System.Windows.Forms.ListBox();
            this.listMinBox = new System.Windows.Forms.ListBox();
            this.CounterMax = new System.Windows.Forms.Label();
            this.CounterNormal = new System.Windows.Forms.Label();
            this.CounterMin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.normalBox = new System.Windows.Forms.Label();
            this.clear_form = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.nameAnimal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leer
            // 
            this.leer.Location = new System.Drawing.Point(185, 165);
            this.leer.Name = "leer";
            this.leer.Size = new System.Drawing.Size(75, 23);
            this.leer.TabIndex = 0;
            this.leer.Text = "Read";
            this.leer.UseVisualStyleBackColor = true;
            this.leer.Click += new System.EventHandler(this.leer_Click);
            // 
            // leerArchivo
            // 
            this.leerArchivo.FileName = "leerArchivo";
            this.leerArchivo.Filter = "Archivos TXT (*.txt)|*.txt";
            // 
            // listMaxBox
            // 
            this.listMaxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMaxBox.FormattingEnabled = true;
            this.listMaxBox.Location = new System.Drawing.Point(140, 23);
            this.listMaxBox.Margin = new System.Windows.Forms.Padding(10);
            this.listMaxBox.Name = "listMaxBox";
            this.listMaxBox.Size = new System.Drawing.Size(120, 43);
            this.listMaxBox.TabIndex = 2;
            // 
            // listMinBox
            // 
            this.listMinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMinBox.FormattingEnabled = true;
            this.listMinBox.Location = new System.Drawing.Point(140, 104);
            this.listMinBox.Margin = new System.Windows.Forms.Padding(10);
            this.listMinBox.Name = "listMinBox";
            this.listMinBox.Size = new System.Drawing.Size(120, 43);
            this.listMinBox.TabIndex = 3;
            // 
            // CounterMax
            // 
            this.CounterMax.AutoSize = true;
            this.CounterMax.Location = new System.Drawing.Point(106, 38);
            this.CounterMax.Name = "CounterMax";
            this.CounterMax.Size = new System.Drawing.Size(13, 13);
            this.CounterMax.TabIndex = 4;
            this.CounterMax.Text = "0";
            this.CounterMax.Click += new System.EventHandler(this.CounterMax_Click);
            // 
            // CounterNormal
            // 
            this.CounterNormal.AutoSize = true;
            this.CounterNormal.Location = new System.Drawing.Point(106, 78);
            this.CounterNormal.Name = "CounterNormal";
            this.CounterNormal.Size = new System.Drawing.Size(13, 13);
            this.CounterNormal.TabIndex = 5;
            this.CounterNormal.Text = "0";
            this.CounterNormal.Click += new System.EventHandler(this.CounterNormal_Click);
            // 
            // CounterMin
            // 
            this.CounterMin.AutoSize = true;
            this.CounterMin.Location = new System.Drawing.Point(106, 119);
            this.CounterMin.Name = "CounterMin";
            this.CounterMin.Size = new System.Drawing.Size(13, 13);
            this.CounterMin.TabIndex = 6;
            this.CounterMin.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Values <";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Values =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Values >";
            // 
            // normalBox
            // 
            this.normalBox.AutoSize = true;
            this.normalBox.Location = new System.Drawing.Point(137, 78);
            this.normalBox.Name = "normalBox";
            this.normalBox.Size = new System.Drawing.Size(13, 13);
            this.normalBox.TabIndex = 10;
            this.normalBox.Text = "0";
            // 
            // clear_form
            // 
            this.clear_form.Location = new System.Drawing.Point(105, 165);
            this.clear_form.Name = "clear_form";
            this.clear_form.Size = new System.Drawing.Size(75, 23);
            this.clear_form.TabIndex = 11;
            this.clear_form.Text = "Clear";
            this.clear_form.UseVisualStyleBackColor = true;
            this.clear_form.Click += new System.EventHandler(this.clear_form_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(25, 165);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 12;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // nameAnimal
            // 
            this.nameAnimal.AutoSize = true;
            this.nameAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameAnimal.Location = new System.Drawing.Point(22, 11);
            this.nameAnimal.Name = "nameAnimal";
            this.nameAnimal.Size = new System.Drawing.Size(50, 17);
            this.nameAnimal.TabIndex = 13;
            this.nameAnimal.Text = "Animal";
            // 
            // Matrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 203);
            this.Controls.Add(this.nameAnimal);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear_form);
            this.Controls.Add(this.normalBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CounterMin);
            this.Controls.Add(this.CounterNormal);
            this.Controls.Add(this.CounterMax);
            this.Controls.Add(this.listMinBox);
            this.Controls.Add(this.listMaxBox);
            this.Controls.Add(this.leer);
            this.Name = "Matrices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leer;
        private System.Windows.Forms.OpenFileDialog leerArchivo;
        private System.Windows.Forms.ListBox listMaxBox;
        private System.Windows.Forms.ListBox listMinBox;
        private System.Windows.Forms.Label CounterMax;
        private System.Windows.Forms.Label CounterNormal;
        private System.Windows.Forms.Label CounterMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label normalBox;
        private System.Windows.Forms.Button clear_form;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label nameAnimal;
    }
}

