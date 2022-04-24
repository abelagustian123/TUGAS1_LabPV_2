/*
 * Created by SharpDevelop.
 * User: Abel Agustian
 * Date: 24/04/2022
 * Time: 14:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugas1Lab
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.nomor_peserta = new System.Windows.Forms.TextBox();
			this.nama_peserta = new System.Windows.Forms.TextBox();
			this.tanggal_lahir = new System.Windows.Forms.TextBox();
			this.pil1 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Insertbtn = new System.Windows.Forms.Button();
			this.Updatebtn = new System.Windows.Forms.Button();
			this.Deletebtn = new System.Windows.Forms.Button();
			this.nisn = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pil2 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.Label();
			this.universitas1 = new System.Windows.Forms.TextBox();
			this.universitas2 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-1, -2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1165, 65);
			this.label1.TabIndex = 0;
			this.label1.Text = "Daftar Peserta UTBK";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(61, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nomor Peserta";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(61, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nama Peserta";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(61, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(154, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tanggal Lahir";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(61, 225);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(154, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "NISN";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(588, 122);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(154, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Pilihan 1";
			// 
			// nomor_peserta
			// 
			this.nomor_peserta.Location = new System.Drawing.Point(233, 89);
			this.nomor_peserta.Name = "nomor_peserta";
			this.nomor_peserta.Size = new System.Drawing.Size(226, 22);
			this.nomor_peserta.TabIndex = 6;
			// 
			// nama_peserta
			// 
			this.nama_peserta.Location = new System.Drawing.Point(233, 134);
			this.nama_peserta.Name = "nama_peserta";
			this.nama_peserta.Size = new System.Drawing.Size(226, 22);
			this.nama_peserta.TabIndex = 7;
			// 
			// tanggal_lahir
			// 
			this.tanggal_lahir.Location = new System.Drawing.Point(233, 180);
			this.tanggal_lahir.Name = "tanggal_lahir";
			this.tanggal_lahir.Size = new System.Drawing.Size(226, 22);
			this.tanggal_lahir.TabIndex = 8;
			// 
			// pil1
			// 
			this.pil1.Location = new System.Drawing.Point(760, 124);
			this.pil1.Name = "pil1";
			this.pil1.Size = new System.Drawing.Size(226, 22);
			this.pil1.TabIndex = 11;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 288);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1142, 244);
			this.dataGridView1.TabIndex = 12;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// Insertbtn
			// 
			this.Insertbtn.BackColor = System.Drawing.Color.Blue;
			this.Insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Insertbtn.ForeColor = System.Drawing.Color.White;
			this.Insertbtn.Location = new System.Drawing.Point(1050, 87);
			this.Insertbtn.Name = "Insertbtn";
			this.Insertbtn.Size = new System.Drawing.Size(91, 58);
			this.Insertbtn.TabIndex = 13;
			this.Insertbtn.Text = "Insert";
			this.Insertbtn.UseVisualStyleBackColor = false;
			this.Insertbtn.Click += new System.EventHandler(this.InsertbtnClick);
			// 
			// Updatebtn
			// 
			this.Updatebtn.BackColor = System.Drawing.Color.Lime;
			this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Updatebtn.ForeColor = System.Drawing.Color.White;
			this.Updatebtn.Location = new System.Drawing.Point(1050, 151);
			this.Updatebtn.Name = "Updatebtn";
			this.Updatebtn.Size = new System.Drawing.Size(91, 58);
			this.Updatebtn.TabIndex = 14;
			this.Updatebtn.Text = "Update";
			this.Updatebtn.UseVisualStyleBackColor = false;
			this.Updatebtn.Click += new System.EventHandler(this.UpdatebtnClick);
			// 
			// Deletebtn
			// 
			this.Deletebtn.BackColor = System.Drawing.Color.Red;
			this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Deletebtn.ForeColor = System.Drawing.Color.White;
			this.Deletebtn.Location = new System.Drawing.Point(1050, 215);
			this.Deletebtn.Name = "Deletebtn";
			this.Deletebtn.Size = new System.Drawing.Size(91, 58);
			this.Deletebtn.TabIndex = 15;
			this.Deletebtn.Text = "Delete";
			this.Deletebtn.UseVisualStyleBackColor = false;
			this.Deletebtn.Click += new System.EventHandler(this.DeletebtnClick);
			// 
			// nisn
			// 
			this.nisn.Location = new System.Drawing.Point(233, 227);
			this.nisn.Name = "nisn";
			this.nisn.Size = new System.Drawing.Size(226, 22);
			this.nisn.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Blue;
			this.label7.Location = new System.Drawing.Point(588, 225);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(154, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "Pilihan 2";
			// 
			// pil2
			// 
			this.pil2.Location = new System.Drawing.Point(760, 225);
			this.pil2.Name = "pil2";
			this.pil2.Size = new System.Drawing.Size(226, 22);
			this.pil2.TabIndex = 13;
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.ForeColor = System.Drawing.Color.Blue;
			this.textBox6.Location = new System.Drawing.Point(588, 87);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(154, 23);
			this.textBox6.TabIndex = 17;
			this.textBox6.Text = "Universitas";
			// 
			// textBox7
			// 
			this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox7.ForeColor = System.Drawing.Color.Blue;
			this.textBox7.Location = new System.Drawing.Point(588, 186);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(154, 23);
			this.textBox7.TabIndex = 18;
			this.textBox7.Text = "Universitas";
			// 
			// universitas1
			// 
			this.universitas1.Location = new System.Drawing.Point(760, 87);
			this.universitas1.Name = "universitas1";
			this.universitas1.Size = new System.Drawing.Size(226, 22);
			this.universitas1.TabIndex = 10;
			// 
			// universitas2
			// 
			this.universitas2.Location = new System.Drawing.Point(760, 188);
			this.universitas2.Name = "universitas2";
			this.universitas2.Size = new System.Drawing.Size(226, 22);
			this.universitas2.TabIndex = 12;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1166, 544);
			this.Controls.Add(this.universitas2);
			this.Controls.Add(this.universitas1);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.pil2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.nisn);
			this.Controls.Add(this.Deletebtn);
			this.Controls.Add(this.Updatebtn);
			this.Controls.Add(this.Insertbtn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pil1);
			this.Controls.Add(this.tanggal_lahir);
			this.Controls.Add(this.nama_peserta);
			this.Controls.Add(this.nomor_peserta);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Tugas1Lab";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox universitas2;
		private System.Windows.Forms.TextBox universitas1;
		private System.Windows.Forms.Label textBox7;
		private System.Windows.Forms.Label textBox6;
		private System.Windows.Forms.TextBox pil2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox nisn;
		private System.Windows.Forms.Button Deletebtn;
		private System.Windows.Forms.Button Updatebtn;
		private System.Windows.Forms.Button Insertbtn;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox pil1;
		private System.Windows.Forms.TextBox tanggal_lahir;
		private System.Windows.Forms.TextBox nama_peserta;
		private System.Windows.Forms.TextBox nomor_peserta;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
