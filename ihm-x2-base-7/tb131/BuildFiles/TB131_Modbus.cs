//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
	using Neo.ApplicationFramework.Tools.Actions;
	
	
	public partial class TB131_Modbus : Neo.ApplicationFramework.Tools.OpcClient.DataSourceContainer
	{
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem1;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem2;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem3;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem4;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem9;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem10;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem11;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem12;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem17;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem18;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem19;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem20;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem5;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem6;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem7;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem8;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem13;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem14;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem15;
		
		private Neo.ApplicationFramework.Tools.OpcClient.DataItem DataItem16;
		
		public TB131_Modbus()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
		}
		
		private void InitializeComponent()
		{
			this.InitializeObjectCreations();
			this.InitializeBeginInits();
			this.InitializeObjects();
			this.InitializeEndInits();
			this.ConnectDataBindings();
		}
		
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		public override void ConnectDataBindings()
		{
			base.ConnectDataBindings();
		}
		
		private void InitializeObjectCreations()
		{
			this.DataItem1 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem1", "00010", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem2 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem2", "00011", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem3 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem3", "00012", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem4 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem4", "00013", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem9 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem9", "10000", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem10 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem10", "10001", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem11 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem11", "10002", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem12 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem12", "10003", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem17 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem17", "30000", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_INTEGER2)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem18 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem18", "30001", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_INTEGER2)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem19 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem19", "40000", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_INTEGER2)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem20 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem20", "40001", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_INTEGER2)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem5 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem5", "00014", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem6 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem6", "00015", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem7 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem7", "00016", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem8 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem8", "00017", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem13 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem13", "10004", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem14 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem14", "10005", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem15 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem15", "10006", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
			this.DataItem16 = new Neo.ApplicationFramework.Tools.OpcClient.DataItem("DataItem16", "10007", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false);
		}
		
		private void InitializeBeginInits()
		{
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem16)).BeginInit();
		}
		
		private void InitializeEndInits()
		{
			((System.ComponentModel.ISupportInitialize)(this.DataItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataItem16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		
		private void InitializeObjects()
		{
			this.DataItems.Add(this.DataItem1);
			this.DataItems.Add(this.DataItem2);
			this.DataItems.Add(this.DataItem3);
			this.DataItems.Add(this.DataItem4);
			this.DataItems.Add(this.DataItem9);
			this.DataItems.Add(this.DataItem10);
			this.DataItems.Add(this.DataItem11);
			this.DataItems.Add(this.DataItem12);
			this.DataItems.Add(this.DataItem17);
			this.DataItems.Add(this.DataItem18);
			this.DataItems.Add(this.DataItem19);
			this.DataItems.Add(this.DataItem20);
			this.DataItems.Add(this.DataItem5);
			this.DataItems.Add(this.DataItem6);
			this.DataItems.Add(this.DataItem7);
			this.DataItems.Add(this.DataItem8);
			this.DataItems.Add(this.DataItem13);
			this.DataItems.Add(this.DataItem14);
			this.DataItems.Add(this.DataItem15);
			this.DataItems.Add(this.DataItem16);
			this.Driver = "Modicon_Modbus_RTU_ASCII_Pre2.Modicon_Modbus_RTU_ASCII_Pre2.1";
			this.Node = "";
			this.Servername = "Beijer.InprocessNeo.1";
			this.TargetInfoString = "iXDeveloper;WinCe6;Beijer;Exter iX;X2 base 7;en;";
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(TB131_Modbus));
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
		}
	}
}
