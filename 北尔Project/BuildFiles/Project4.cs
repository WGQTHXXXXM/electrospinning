using System.Collections;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Neo.ApplicationFramework.Common;
using Neo.ApplicationFramework.Common.Runtime;
using Neo.ApplicationFramework.Common.Service;
using Neo.ApplicationFramework.Common.TypeConverters;
using Neo.ApplicationFramework.Common.Utilities;
using Neo.ApplicationFramework.Tools.ToolManager;
using Neo.ApplicationFramework.Interfaces;
using Neo.ApplicationFramework.Attributes;
using System.Threading;
using System.Linq;

[assembly: AssemblyVersion("2.0.463.0")]
[assembly: NeoDesignerVersion("2.0.463.0")]

namespace Neo.ApplicationFramework.Generated
{
    public class Globals : GlobalsBase
    {
        private static readonly log4net.ILog m_Log = log4net.LogManager.GetLogger(typeof(Globals));
        private static string[] m_Arguments;

        static Globals()
        {
            
        }

        public Globals()
        {
            m_ProjectSettings.MainScreenTitle = "Project4";
            m_ProjectSettings.Topmost = false;
            m_ProjectSettings.StartupLocation = new Point(0, 0);
            m_ProjectSettings.MaximizeOnStartup = false;
            m_ProjectSettings.MainScreenSize = new Size(640,480);
            m_ProjectSettings.BorderStyle = ScreenBorderStyle.ThreeDBorder;
            m_ProjectSettings.InputDelay = 2000;
            m_ProjectSettings.IsOnScreenKeyboardEnabled = true;
            m_ProjectSettings.KeyboardLayoutName = "US";
            m_ProjectSettings.TerminalGroup = TerminalGroup.Default;
            m_SystemSettings.AutomaticallyTurnOfBacklight = false;
            m_SystemSettings.BacklightTimeout = 900;    
            m_SystemSettings.KeepBacklightOnIfNotifierWindowIsVisible = false;
            Dictionary<ComPort, PortMode> comPortModes = new Dictionary<ComPort, PortMode>();
            comPortModes.Add(ComPort.COM1, PortMode.Nonconfigurable); comPortModes.Add(ComPort.COM2, PortMode.rs422); comPortModes.Add(ComPort.COM3, PortMode.Nonconfigurable); comPortModes.Add(ComPort.COM4, PortMode.rs422);                            
            m_SystemSettings.ComPortModes = comPortModes;                            
            m_SystemSettings.KeyBeep = true;
            m_SystemSettings.TimeZoneDisplayName = "";
            m_SystemSettings.RegionLCID = 0;
            m_SystemSettings.AdjustForDaylightSaving = true;
            m_SystemSettings.FtpServerEnabled = false;
            m_SystemSettings.FtpServerAllowAnonymous = false;
            m_SystemSettings.FtpServerDefaultDir = @"";
            m_SystemSettings.NTLMUser = @"";
            m_SystemSettings.NTLMPassword = @"";
            m_SystemSettings.VncServerEnabled = false;
            m_SystemSettings.VncTcpPort = 5900;
            m_SystemSettings.VncHttpTcpPort = 5800;
            m_SystemSettings.VncViewOnlyPassword = @"";
            m_SystemSettings.VncFullAccessPassword = @"";
            m_SystemSettings.IsKeyPanel = false;
            m_SystemSettings.AlarmButtonShowScreenTarget = @"";
            m_SystemSettings.ScreenRotationAngle = 0;
            m_SystemSettings.BeShellMenuPassword = @"";
            m_SystemSettings.ProjectGuid = new Guid("86df5c6a-e6f1-4fa0-b6b9-54613d993769");
        }
        
        
       

        /// <summary>
        /// Neo generated code - do not modify
        /// the contents of this method(s) with the code editor.
        /// </summary>        
                    public static IPrinterDevice Printer1
                    {
                        get
                        {
                            IDeviceManagerServiceCF deviceManagerService = ServiceContainerCF.GetService<IDeviceManagerServiceCF>();
                            return deviceManagerService.GetOutputDevice<IPrinterDevice>();
                        }
                    }           
                    public static IScreenAdapter Screen3
                    {
                        get
                        {
                            return GetScreenObject<Screen3>().Adapter;
                        }
                    }           
                    public static IScreenAdapter Screen2
                    {
                        get
                        {
                            return GetScreenObject<Screen2>().Adapter;
                        }
                    }           
                    public static ScriptModule1 ScriptModule1
                    {
                        get
                        {
                            return GetObject<ScriptModule1>();
                        }
                    }           
                    public static IScreenAdapter Screen1
                    {
                        get
                        {
                            return GetScreenObject<Screen1>().Adapter;
                        }
                    }           
                    public static TextLibrary TextLibrary
                    {
                        get
                        {
                            return GetObject<TextLibrary>();
                        }
                    }           
                    public static FunctionKeys FunctionKeys
                    {
                        get
                        {
                            return GetObject<FunctionKeys>();
                        }
                    }           
                    public static Security Security
                    {
                        get
                        {
                            return GetObject<Security>();
                        }
                    }           
                    public static ProjectConfiguration ProjectConfiguration
                    {
                        get
                        {
                            return GetObject<ProjectConfiguration>();
                        }
                    }           
                    public static Expressions Expressions
                    {
                        get
                        {
                            return GetObject<Expressions>();
                        }
                    }           
                    public static Tags Tags
                    {
                        get
                        {
                            return GetObject<Tags>();
                        }
                    }           
                    public static AlarmServer AlarmServer
                    {
                        get
                        {
                            return GetObject<AlarmServer>();
                        }
                    }           
                    public static MultipleLanguages MultipleLanguages
                    {
                        get
                        {
                            return GetObject<MultipleLanguages>();
                        }
                    }           
                    public static LicenseRootComponent LicenseRootComponent
                    {
                        get
                        {
                            return GetObject<LicenseRootComponent>();
                        }
                    }   
        [MTAThread]
        static void Main(string[] args)
        {
            
            
            
			if (!CheckIfApplicationCanRun())
				return;

            UserStartupMessage.SendUserStartupMessageToBeijerShell("Loading Files");
            if (!StopWatchCF.Silent)
                StopWatchCF.Send("Starting Project");
            StopWatchCF.SetTimeStamp("***** Project Startup Time *****");
            while (ProcessExplorer.WaitForAttachDebugger)
            {
                Thread.Sleep(1000);
            }
            IsCompiledForCE = true;   

            Instance = new Globals();

            try
            {
                m_Arguments = args;
                
                m_ToolManager.OnToolAdded += OnToolAdded;
                m_ToolManager.LoadTools();
                SetRenderingMode();

                INativeAPI nativeAPI = Globals.GetService<IPlatformFactoryService>().Create<INativeAPI>();
                CreateMutex(nativeAPI);

                if (Marshal.GetLastWin32Error() != (int)CREATEMUTEX.ERROR_ALREADY_EXISTS)
                {
                    ((Globals)Instance).SetBeShellMenuPassword();
                    ((Globals)Instance).SetScreenOrientation();
                    ((Globals)Instance).SetSerialPortMode();
                    ((Globals)Instance).SetKeyBeep();
                    ((Globals)Instance).ConfigureFtpServer();
                    ((Globals)Instance).StartVncServerCe();

                    nativeAPI.CeSetThreadQuantum(new IntPtr(65), 25);
                    InterpreterArguments(args);
                    ExecutablePath = typeof(Globals).Module.FullyQualifiedName;
                    RegisterDrivers();
                    
                    NeoApplication.Initialize();

                    m_ToolManager.Start();

                    Instanciate(new string[] {"TextLibrary","Security","Tags","MultipleLanguages","LicenseRootComponent","AlarmServer","Expressions","Database","ProjectConfiguration","FunctionKeys","ScriptModule1","ProjectImages"});
                    PreloadScreens = new string[] {}.Select(item => Type.GetType(string.Concat(StringConstants.NeoApplicationFrameworkGenerated, ".", item, ",", Assembly.GetExecutingAssembly().FullName), true)).ToArray();


                    InitAndRun();
                    NeoApplication.Run(Screen1.AdaptedObject);  
                    CloseRunningOnScreenKeyboard();
                    CloseRunningVncserverCe();                  
                }

                m_ToolManager.StopStoppable();
                Stop();
            }
            catch(ControledRequestForShutdownException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                GenerateCrashReport(ex);
                ManageUnhandledException(ex, true);
                m_ShowUnhandledException = false;

                throw; //Preserves stacktrace and triggers Dr Watson to create dump file.
            }
        }

        private static void OnToolAdded(object sender, EventArgs e)
        {
            if (sender is ICommandLineService)
            {
                ServiceContainerCF.GetService<ICommandLineService>().Arguments = m_Arguments;
            }
        }

        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        internal class Lazy<T>
        {
            private bool m_IsValueCreated = false;
            private T m_Value = default(T);
            private Func<T> m_Initializer = null;

            public Lazy(Func<T> initializer)
            {
                m_Initializer = initializer;
            }

            public bool IsValueCreated 
            { 
                get { return m_IsValueCreated; }
            }

            public T Value
            {
                get
                {
                    if(!m_IsValueCreated)
                    {
                        m_Value = m_Initializer();
                        m_IsValueCreated = true;
                    }
                    return m_Value;
                }
            }
        }
        
    }
}