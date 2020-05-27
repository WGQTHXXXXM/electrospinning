//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
	using Neo.ApplicationFramework.Tools.Actions;
	
	
	public partial class Tags : Neo.ApplicationFramework.Tools.OpcClient.GlobalController
	{
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_RS;
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_ASD;
		
		private Neo.ApplicationFramework.Tools.OpcClient.PollGroup m_PollGroup1;
		
		private Neo.ApplicationFramework.Tools.OpcClient.PollGroup m_PollGroup2;
		
		private Neo.ApplicationFramework.Tools.OpcClient.PollGroup m_PollGroup3;
		
		private Neo.ApplicationFramework.Tools.OpcClient.PollGroup m_PollGroup4;
		
		private Neo.ApplicationFramework.Tools.OpcClient.PollGroup m_PollGroup5;
		
		public Tags()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem RS
		{
			get
			{
				return this.m_RS;
			}
			set
			{
				this.m_RS = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem ASD
		{
			get
			{
				return this.m_ASD;
			}
			set
			{
				this.m_ASD = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup1
		{
			get
			{
				return this.m_PollGroup1;
			}
			set
			{
				this.m_PollGroup1 = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup2
		{
			get
			{
				return this.m_PollGroup2;
			}
			set
			{
				this.m_PollGroup2 = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup3
		{
			get
			{
				return this.m_PollGroup3;
			}
			set
			{
				this.m_PollGroup3 = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup4
		{
			get
			{
				return this.m_PollGroup4;
			}
			set
			{
				this.m_PollGroup4 = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup5
		{
			get
			{
				return this.m_PollGroup5;
			}
			set
			{
				this.m_PollGroup5 = value;
			}
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
			this.RS = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("RS", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", Neo.ApplicationFramework.Interfaces.AccessRights.Write, "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), "", ((short)(1)));
			this.ASD = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("ASD", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Neo.ApplicationFramework.Interfaces.AccessRights)((Neo.ApplicationFramework.Interfaces.AccessRights.Read | Neo.ApplicationFramework.Interfaces.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), null, ((short)(1)));
			this.PollGroup1 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup2 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup3 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup4 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup5 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
		}
		
		private void InitializeBeginInits()
		{
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
		}
		
		private void InitializeEndInits()
		{
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		
		private void InitializeObjects()
		{
			this.RS.AccessRights.Add("B140", Neo.ApplicationFramework.Interfaces.AccessRights.None);
			this.RS.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(new Neo.ApplicationFramework.Interfaces.VariantValue(""), 0, new string[] {
							"B140"}, new string[] {
							"DataItem1"}, true));
			this.ASD.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[0], new string[0], true));
			this.GlobalDataItems.Add(this.RS);
			this.GlobalDataItems.Add(this.ASD);
			this.PollGroup1.Interval = 500;
			this.PollGroup1.Name = "PollGroup1";
			this.PollGroup2.Interval = 500;
			this.PollGroup2.Name = "PollGroup2";
			this.PollGroup3.Interval = 500;
			this.PollGroup3.Name = "PollGroup3";
			this.PollGroup4.Interval = 500;
			this.PollGroup4.Name = "PollGroup4";
			this.PollGroup5.Interval = 500;
			this.PollGroup5.Name = "PollGroup5";
			this.PollGroups.Add(this.PollGroup1);
			this.PollGroups.Add(this.PollGroup2);
			this.PollGroups.Add(this.PollGroup3);
			this.PollGroups.Add(this.PollGroup4);
			this.PollGroups.Add(this.PollGroup5);
			this.ServerInfo += new System.EventHandler<Neo.ApplicationFramework.Interfaces.Events.ServerInfoArgs>(this.Tags_ServerInfo);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(Tags));
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
		}
	}
}
