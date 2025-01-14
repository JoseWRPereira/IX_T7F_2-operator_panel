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
	using Neo.ApplicationFramework.Tools.Alarm;
	
	
	public partial class AlarmServer : Neo.ApplicationFramework.Tools.Alarm.AlarmServer
	{
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmGroup m_Default;
		
		public AlarmServer()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmGroup Default
		{
			get
			{
				return this.m_Default;
			}
			set
			{
				this.m_Default = value;
			}
		}
		
		private void InitializeComponent()
		{
			this.InitializeObjectCreations();
			// 
			// AlarmServer
			// 
			// 
			// Default
			// 
			this.Default.AcknowledgeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(127)))), ((int)(((byte)(70)))));
			this.Default.AcknowledgeForeColor = System.Drawing.Color.Black;
			this.Default.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(19)))), ((int)(((byte)(41)))));
			this.Default.ActiveForeColor = System.Drawing.Color.Black;
			this.Default.EnableDistribution = false;
			this.Default.InactiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(204)))), ((int)(((byte)(71)))));
			this.Default.InactiveForeColor = System.Drawing.Color.Black;
			this.Default.Name = "Default";
			this.Default.NormalBackColor = System.Drawing.SystemColors.Window;
			this.Default.NormalForeColor = System.Drawing.Color.Black;
			this.AlarmGroups.Add(this.Default);
			this.StorageEvent.AcknowledgeTime = null;
			this.StorageEvent.ActiveTime = null;
			this.StorageEvent.AlarmGroupName = "";
			this.StorageEvent.AlarmGroupText = "";
			this.StorageEvent.AlarmItemId = new System.Guid("00000000-0000-0000-0000-000000000000");
			this.StorageEvent.Count = 0;
			this.StorageEvent.DisplayText = "";
			this.StorageEvent.EnableDistribution = false;
			this.StorageEvent.ForceToList = false;
			this.StorageEvent.History = false;
			this.StorageEvent.InActiveTime = null;
			this.StorageEvent.NormalTime = null;
			this.StorageEvent.RepeatCount = false;
			this.StorageEvent.State = Neo.ApplicationFramework.Interfaces.AlarmState.Normal;
			this.StorageEvent.TableName = "AlarmServer";
			this.StorageEvent.Text = "";
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
			this.Default = new Neo.ApplicationFramework.Tools.Alarm.AlarmGroup();
		}
		
		private void InitializeBeginInits()
		{
		}
		
		private void InitializeEndInits()
		{
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(AlarmServer));
			this.m_Default.Text = resources.GetText("AlarmServer.Default.Text", "Default");
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
		}
	}
}
