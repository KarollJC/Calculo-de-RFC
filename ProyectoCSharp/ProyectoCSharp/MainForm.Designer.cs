/*
 * Created by SharpDevelop.
 * User: CC2_PC24
 * Date: 23/10/2024
 * Time: 07:35 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoCSharp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPaterno = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.cbSemestre = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.mcNacimiento = new System.Windows.Forms.MonthCalendar();
			this.txtMaterno = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblRFC = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(190, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Apellido P.";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(317, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Apellido M.";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(34, 84);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(150, 20);
			this.txtName.TabIndex = 3;
			// 
			// txtPaterno
			// 
			this.txtPaterno.Location = new System.Drawing.Point(190, 84);
			this.txtPaterno.Name = "txtPaterno";
			this.txtPaterno.Size = new System.Drawing.Size(121, 20);
			this.txtPaterno.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(288, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Num. telefono";
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(288, 164);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(150, 20);
			this.txtTel.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(34, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Direccion";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(34, 164);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(150, 20);
			this.txtDireccion.TabIndex = 9;
			// 
			// cbSemestre
			// 
			this.cbSemestre.FormattingEnabled = true;
			this.cbSemestre.Items.AddRange(new object[] {
			"1",
			"2",
			"3"});
			this.cbSemestre.Location = new System.Drawing.Point(190, 163);
			this.cbSemestre.Name = "cbSemestre";
			this.cbSemestre.Size = new System.Drawing.Size(92, 21);
			this.cbSemestre.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(190, 137);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Semestre";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(94, 213);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(130, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Fecha Nacimiento";
			// 
			// mcNacimiento
			// 
			this.mcNacimiento.Location = new System.Drawing.Point(34, 245);
			this.mcNacimiento.Name = "mcNacimiento";
			this.mcNacimiento.TabIndex = 13;
			// 
			// txtMaterno
			// 
			this.txtMaterno.Location = new System.Drawing.Point(317, 84);
			this.txtMaterno.Name = "txtMaterno";
			this.txtMaterno.Size = new System.Drawing.Size(121, 20);
			this.txtMaterno.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(173, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(201, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = "CALCULO DE RFC";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(317, 262);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "Tu RFC es:";
			// 
			// lblRFC
			// 
			this.lblRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRFC.Location = new System.Drawing.Point(317, 285);
			this.lblRFC.Name = "lblRFC";
			this.lblRFC.Size = new System.Drawing.Size(100, 23);
			this.lblRFC.TabIndex = 17;
			this.lblRFC.Text = ". . .";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(330, 349);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 18;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(470, 429);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblRFC);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtMaterno);
			this.Controls.Add(this.mcNacimiento);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbSemestre);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPaterno);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "ProyectoCSharp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblRFC;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.MonthCalendar mcNacimiento;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbSemestre;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMaterno;
		private System.Windows.Forms.TextBox txtPaterno;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
