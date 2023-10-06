
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security;
using EstadosCuenta.Biblioteca;

namespace Godel.Posts
{
	/// <summary>
	/// Description of EstadosCuenta.
	/// </summary>
	public partial class EstadosCuenta : Form
	{
		public EstadosCuenta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Init();
		}
		
		void Init(){
			cbBanco.Items.AddRange(new object[] {"Bancomer","Banamex","IXE","Banorte"});
			cbTipoMovimiento.Items.AddRange(new object[] {"Deposito","Retiro"});
		}
		
		void TbPanelMainPaint(object sender, PaintEventArgs e)
		{
			
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnGenerarClick(object sender, EventArgs e)
		{
            try
            {
                Ensamblado1 ensamblado1 = new Ensamblado1();
                ensamblado1.Banco = cbBanco.SelectedItem.ToString();
                ensamblado1.TipoMovimiento = cbTipoMovimiento.SelectedItem.ToString();
                ensamblado1.Descripcion = txtDescripcion.Text;
                ensamblado1.Monto = txtMonto.Text;
                string fileName = string.Format("{0}{1}.xml", 
                    ensamblado1.Banco, 
                    ensamblado1.Fecha.Replace("/", "_"));
                string path = @txtPath.Text;
                ensamblado1.WriteBank(fileName, path);
                MessageBox.Show("Estado de cuenta generado!");
            }
            catch (ApplicationException appex) 
            { 
                MessageBox.Show(appex.Message); 
            }
            catch (SecurityException ex) { 
                MessageBox.Show(ex.Message); 
            }
		}
	}
}
