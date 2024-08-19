using System;
using System.IO;
using System.Xml;
using System.Security.Permissions;
using System.Text;

namespace EstadosCuenta.Biblioteca
{
	public sealed class Ensamblado1
	{		
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region 
		string banco,tipoMovimiento,descripcion,monto;
		#endregion
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        [FileIOPermission(SecurityAction.PermitOnly,
            Write = "C:\\Movimientos",
            ViewAndModify = "C:\\Movimientos")]
		public void WriteBank(string fileName,string rootPath)
		{
            string directoryPath = @rootPath + Path.DirectorySeparatorChar;
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            XmlTextWriter tw = new XmlTextWriter(directoryPath + fileName, Encoding.UTF8);
				tw.Formatting = Formatting.Indented;
				tw.WriteStartDocument();
				tw.WriteStartElement("BankStatement");
				tw.WriteElementString("Date",Fecha);
				tw.WriteElementString("Bank",Banco);
				tw.WriteElementString("MovementType",TipoMovimiento);
				tw.WriteElementString("Description",Descripcion);
				tw.WriteElementString("Amount",Monto);
				tw.WriteEndDocument();
				tw.Flush();
				tw.Close();
		}
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region
		public string Banco{ set{ banco = value;} get{ return banco;} }
		public string TipoMovimiento{set{ tipoMovimiento = value;}get{ return  tipoMovimiento;}}
		public string Descripcion{set{ descripcion = value;}get{return  descripcion;}}
		public string Monto{set{ monto = value;}get{return  monto;}}
		public string Fecha{get{return DateTime.Now.ToShortDateString();}}
		#endregion
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}
}
