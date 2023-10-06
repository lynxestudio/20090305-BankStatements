/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 03/03/2009
 * Time: 09:23 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Godel.Posts
{
	partial class EstadosCuenta
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
            this.tbLayoutButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.tbLayoutButtons.SuspendLayout();
            this.tbPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLayoutButtons
            // 
            this.tbLayoutButtons.BackColor = System.Drawing.Color.LightGray;
            this.tbLayoutButtons.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tbLayoutButtons.ColumnCount = 2;
            this.tbLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutButtons.Controls.Add(this.btnGenerar, 0, 0);
            this.tbLayoutButtons.Controls.Add(this.btnCancelar, 1, 0);
            this.tbLayoutButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLayoutButtons.Location = new System.Drawing.Point(0, 228);
            this.tbLayoutButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLayoutButtons.Name = "tbLayoutButtons";
            this.tbLayoutButtons.RowCount = 1;
            this.tbLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutButtons.Size = new System.Drawing.Size(381, 42);
            this.tbLayoutButtons.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenerar.Location = new System.Drawing.Point(6, 7);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(87, 28);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Aceptar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerarClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Location = new System.Drawing.Point(288, 7);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
            // 
            // tbPanelMain
            // 
            this.tbPanelMain.ColumnCount = 2;
            this.tbPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbPanelMain.Controls.Add(this.txtPath, 1, 4);
            this.tbPanelMain.Controls.Add(this.lb5, 0, 4);
            this.tbPanelMain.Controls.Add(this.lbl1, 0, 0);
            this.tbPanelMain.Controls.Add(this.lbl2, 0, 1);
            this.tbPanelMain.Controls.Add(this.lbl3, 0, 2);
            this.tbPanelMain.Controls.Add(this.lbl4, 0, 3);
            this.tbPanelMain.Controls.Add(this.txtMonto, 1, 3);
            this.tbPanelMain.Controls.Add(this.txtDescripcion, 1, 2);
            this.tbPanelMain.Controls.Add(this.cbTipoMovimiento, 1, 1);
            this.tbPanelMain.Controls.Add(this.cbBanco, 1, 0);
            this.tbPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tbPanelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPanelMain.Name = "tbPanelMain";
            this.tbPanelMain.RowCount = 5;
            this.tbPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPanelMain.Size = new System.Drawing.Size(381, 228);
            this.tbPanelMain.TabIndex = 1;
            this.tbPanelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.TbPanelMainPaint);
            // 
            // txtPath
            // 
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath.Location = new System.Drawing.Point(231, 183);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(147, 23);
            this.txtPath.TabIndex = 13;
            this.txtPath.Text = "C:\\\\Movimientos";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(3, 180);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(124, 32);
            this.lb5.TabIndex = 12;
            this.lb5.Text = " Ubicacion permitida (c:\\Movimientos)";
            this.lb5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1.Location = new System.Drawing.Point(3, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(222, 45);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Banco";
            // 
            // lbl2
            // 
            this.lbl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl2.Location = new System.Drawing.Point(3, 45);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(222, 45);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Tipo de movimiento";
            // 
            // lbl3
            // 
            this.lbl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl3.Location = new System.Drawing.Point(3, 90);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(222, 45);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Descripcion";
            // 
            // lbl4
            // 
            this.lbl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(3, 135);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(222, 45);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMonto.Location = new System.Drawing.Point(231, 139);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(147, 23);
            this.txtMonto.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Location = new System.Drawing.Point(231, 94);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(147, 37);
            this.txtDescripcion.TabIndex = 5;
            // 
            // cbTipoMovimiento
            // 
            this.cbTipoMovimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMovimiento.FormattingEnabled = true;
            this.cbTipoMovimiento.Location = new System.Drawing.Point(231, 49);
            this.cbTipoMovimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipoMovimiento.Name = "cbTipoMovimiento";
            this.cbTipoMovimiento.Size = new System.Drawing.Size(147, 24);
            this.cbTipoMovimiento.TabIndex = 6;
            // 
            // cbBanco
            // 
            this.cbBanco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Location = new System.Drawing.Point(231, 4);
            this.cbBanco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(147, 24);
            this.cbBanco.TabIndex = 7;
            // 
            // EstadosCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 270);
            this.Controls.Add(this.tbPanelMain);
            this.Controls.Add(this.tbLayoutButtons);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "EstadosCuenta";
            this.Text = "Generar estados de cuenta";
            this.tbLayoutButtons.ResumeLayout(false);
            this.tbPanelMain.ResumeLayout(false);
            this.tbPanelMain.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.ComboBox cbBanco;
		private System.Windows.Forms.ComboBox cbTipoMovimiento;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtMonto;
		private System.Windows.Forms.Label lbl4;
		private System.Windows.Forms.Label lbl3;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.TableLayoutPanel tbPanelMain;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TableLayoutPanel tbLayoutButtons;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lb5;
	}
}
