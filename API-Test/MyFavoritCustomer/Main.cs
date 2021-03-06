/***************************************************************
    *  DO NOT EDIT THIS FILE!
    *         
    *  This file is automatically generated by HP Service Test.
    *  Manually changing the contents of this file may result in 
    *  loss of information.
    *          
    *  To edit the test, open the file ‘MyFavoritCustomer.st’ 
    *  in HP Service Test.
     ***************************************************************/
    
    namespace Script
    {
    using System;
    using System.Text;
    using System.Threading;
    using System.Xml;
    using System.Xml.Schema;
    using HP.ST.Fwk.ReporterFWK;
    using HP.ST.Shared.Utilities;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.HelperClasses;
    using HP.ST.Fwk.RunTimeFWK.CompositeActivities;
    using HP.ST.Ext.BindingImpl.Setters.DataSourceSetters;
    using HP.ST.Fwk.JVMLoader;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using HP.ST.Fwk.SOAReplayAPI;
    using HP.ST.Fwk.UFTLicensing;
    
    
    
    public partial class WorkFlowScript : STWorkFlowScriptBase
    {    
    	TestUserCode _userCode = null;
    	TestEntities _flow = null;
    	static Reporter reporter;
    	int reportLevelInTree;
        HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator reportCreator;
    	
    	public BindDirection bind_dir39 = null;
        public BindDirection bind_dir40 = null;
        public BindDirection bind_dir41 = null;
        public BindDirection bind_dir42 = null;
        public HP.ST.Ext.BasicActivities.DataCursorActivity DataCursorActivity16 = null;
        public BindDirection bind_dir43 = null;
        public HP.ST.Fwk.SOAReplayAPI.DataHandling.CursorMovementPolicy DataCursorActivity16_Policy = null;
        public BindDirection bind_dir44 = null;
        public BindDirection bind_dir45 = null;
        public BindDirection bind_dir46 = null;
        public BindDirection bind_dir47 = null;
        
        public IEnumerable<FeaturesGroup> LicensedFeatures
        {
        
        get
        {
        List<FeaturesGroup> features = new List<FeaturesGroup>();
        return features;
        
        }
        
        }
        
        public WorkFlowScript()
            : base(VuserClass.CommandLineArguments, new STRunTimeContext(), "test")
        {	
        	UpdateContextWithActionFolder(String.Empty);
        	
        }
        
        public WorkFlowScript(ISTRunTimeContext ctx)
            : base(VuserClass.CommandLineArguments, ctx, "test")
            
        {
        	this._context = ctx;
        	UpdateContextWithActionFolder(String.Empty);
        	UpdateTestSettings(ctx);
        }
        
        internal void InitializeComponent()
        {
        	LoadInput();
        	
        	InitReport();
        	
        	InitializeEncryptionManagerValues();
        
        	_userCode = new TestUserCode();
            _flow = _userCode;
            _flow.Context=this._context;
            
            
        
        	_flow.DataFetchActivity12 = new HP.ST.Ext.BasicActivities.DataFetchActivity(_context,"DataFetchActivity12");
            _flow.DataFetchActivity9 = new HP.ST.Ext.BasicActivities.DataFetchActivity(_context,"DataFetchActivity9");
            _flow.StartActivity1 = new HP.ST.Ext.BasicActivities.StartActivity(_context,"StartActivity1");
            _flow.Loop2 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input>(_context,"Loop2",LoopType.For);
            _flow.DataExporterActivity11 = new HP.ST.Ext.BasicActivities.DataExporterActivity(_context,"DataExporterActivity11");
            _flow.DataExporterActivity14 = new HP.ST.Ext.BasicActivities.DataExporterActivity(_context,"DataExporterActivity14");
            _flow.DataExporterCloseActivity15 = new HP.ST.Ext.BasicActivities.DataExporterCloseActivity(_context,"DataExporterCloseActivity15");
            _flow.EndActivity3 = new HP.ST.Ext.BasicActivities.EndActivity(_context,"EndActivity3");
            _flow.DataDisconnectActivity10 = new HP.ST.Ext.BasicActivities.DataDisconnectActivity(_context,"DataDisconnectActivity10");
            _flow.DataDisconnectActivity13 = new HP.ST.Ext.BasicActivities.DataDisconnectActivity(_context,"DataDisconnectActivity13");
            this.DataCursorActivity16 = new HP.ST.Ext.BasicActivities.DataCursorActivity(_context,"DataCursorActivity16");
            this.DataCursorActivity16_Policy = new HP.ST.Fwk.SOAReplayAPI.DataHandling.CursorMovementPolicy();
            _flow.Sequence8 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence(_context,"Sequence8");
            _flow.StServiceCallActivity4 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity4");
            _flow.StServiceCallActivity7 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity7");
            _flow.DataFetchActivity12.Comment = @"";
            _flow.DataFetchActivity12.IconPath = @"";
            _flow.DataFetchActivity12.AssemblyPath = @"AddIns\ServiceTest\BaseDataProviders\HP.ST.Ext.CustomDataProviders.dll";
            _flow.DataFetchActivity12.QueryClassName = @"HP.ST.Ext.CustomDataProviders.ExcelFileDataQuery";
            XmlDocument DataFetchActivity12_QueryParameters_Document = new XmlDocument();
            DataFetchActivity12_QueryParameters_Document.PreserveWhitespace = true;
            string xmlDataFetchActivity12Params = @"<Arguments><QueryParametersContainer><QueryParameter><Name>Id</Name><Value>f7085755-1cb9-4cbe-9778-972e94a4607a</Value></QueryParameter><QueryParameter><Name>QueryName</Name><Value>CityPairs!Output</Value></QueryParameter><QueryParameter><Name>IsEmbedded</Name><Value>False</Value></QueryParameter><QueryParameter><Name>Externalized</Name><Value>False</Value></QueryParameter><QueryParameter><Name>GroupText</Name><Value>CityPairs</Value></QueryParameter><QueryParameter><Name>FilePath</Name><Value>" + _context.ResourceManager.GetValue("{CityPairs!Output.TablePath}") + "</Value></QueryParameter><QueryParameter><Name>SheetName</Name><Value>Output$</Value></QueryParameter><QueryParameter><Name>ContainsHeadersRow</Name><Value>True</Value></QueryParameter></QueryParametersContainer></Arguments>";
            DataFetchActivity12_QueryParameters_Document.LoadXml(xmlDataFetchActivity12Params);
            _flow.DataFetchActivity12.QueryParameters = DataFetchActivity12_QueryParameters_Document;
            _flow.dataSourceNameToDataSource.Add("CityPairs!Output", _flow.DataFetchActivity12);
            this.Activities.Add (_flow.DataFetchActivity12);
            _flow.DataFetchActivity9.Comment = @"";
            _flow.DataFetchActivity9.IconPath = @"";
            _flow.DataFetchActivity9.AssemblyPath = @"AddIns\ServiceTest\BaseDataProviders\HP.ST.Ext.CustomDataProviders.dll";
            _flow.DataFetchActivity9.QueryClassName = @"HP.ST.Ext.CustomDataProviders.ExcelFileDataQuery";
            XmlDocument DataFetchActivity9_QueryParameters_Document = new XmlDocument();
            DataFetchActivity9_QueryParameters_Document.PreserveWhitespace = true;
            string xmlDataFetchActivity9Params = @"<Arguments><QueryParametersContainer><QueryParameter><Name>Id</Name><Value>35ef149e-d097-45c2-8b37-def207f7e84c</Value></QueryParameter><QueryParameter><Name>QueryName</Name><Value>CityPairs!Input</Value></QueryParameter><QueryParameter><Name>IsEmbedded</Name><Value>False</Value></QueryParameter><QueryParameter><Name>Externalized</Name><Value>False</Value></QueryParameter><QueryParameter><Name>GroupText</Name><Value>CityPairs</Value></QueryParameter><QueryParameter><Name>FilePath</Name><Value>" + _context.ResourceManager.GetValue("{CityPairs!Input.TablePath}") + "</Value></QueryParameter><QueryParameter><Name>SheetName</Name><Value>Input$</Value></QueryParameter><QueryParameter><Name>ContainsHeadersRow</Name><Value>True</Value></QueryParameter></QueryParametersContainer></Arguments>";
            DataFetchActivity9_QueryParameters_Document.LoadXml(xmlDataFetchActivity9Params);
            _flow.DataFetchActivity9.QueryParameters = DataFetchActivity9_QueryParameters_Document;
            _flow.dataSourceNameToDataSource.Add("CityPairs!Input", _flow.DataFetchActivity9);
            this.Activities.Add (_flow.DataFetchActivity9);
            _flow.StartActivity1.Comment = @"";
            _flow.StartActivity1.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.StartActivity1.Name = @"Start";
            _flow.StartActivity1.JVM = new HP.ST.Ext.BasicActivities.JVMProperties();
            _flow.StartActivity1.IsJavaUsed = false;
            _flow.StartActivity1.JVM.Classpath = @"%CLASSPATH%";
            _flow.StartActivity1.JVM.AdditionalVMParameters = @"";
            _flow.StartActivity1.JMS = new HP.ST.Ext.BasicActivities.JMSProperties();
            _flow.StartActivity1.IsJmsUsed = false;
            _flow.StartActivity1.JMS.JNDIContextFactory = @"<Select...>";
            _flow.StartActivity1.JMS.JNDIProviderUrl = @"";
            _flow.StartActivity1.JMS.JMSConnectionFactory = @"";
            _flow.StartActivity1.JMS.SecurityPrincipal = @"";
            _flow.StartActivity1.JMS.SecurityCredentials = @"";
            _flow.StartActivity1.JMS.ConnectionsPerProcess = @"1";
            _flow.StartActivity1.JMS.TimeoutOptions = @"DN_User_defined_Timeout";
            _flow.StartActivity1.JMS.UserTimeout = @"20";
            _flow.StartActivity1.JMS.GenerateAutoSelector = @"No";
            this.Activities.Add (_flow.StartActivity1);
            _flow.Loop2.ConditionAsString = @"Run for 4 iterations";
            _flow.Loop2.NumberOfIterations = (int)4;
            _flow.Loop2.Comment = @"";
            _flow.Loop2.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_loop.png";
            _flow.Loop2.Name = @"Test Flow";
            _flow.Loop2.Activities.Add (this.DataCursorActivity16);
            _flow.Loop2.Activities.Add (_flow.Sequence8);
            this.Activities.Add (_flow.Loop2);
            _flow.DataExporterActivity11.Comment = @"";
            _flow.DataExporterActivity11.IconPath = @"";
            VTDPropertyInfoBase pi77 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter39 = new VTDObjectGetter(pi77);
            VTDPropertyInfoBase pi78 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter39 = new VTDObjectSetter(pi78);
            binding_setter39 = new StringFormaterDecorator(binding_setter39,"{Step.DataFetchActivity9.OutTable}");
            bind_dir39 = new BindDirection(_flow.DataFetchActivity9,binding_getter39,binding_setter39,BindTargetType.ToInProperty);
            _flow.DataExporterActivity11.InDirections.Add(bind_dir39);
            this.Activities.Add (_flow.DataExporterActivity11);
            _flow.DataExporterActivity14.Comment = @"";
            _flow.DataExporterActivity14.IconPath = @"";
            VTDPropertyInfoBase pi79 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter40 = new VTDObjectGetter(pi79);
            VTDPropertyInfoBase pi80 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter40 = new VTDObjectSetter(pi80);
            binding_setter40 = new StringFormaterDecorator(binding_setter40,"{Step.DataFetchActivity12.OutTable}");
            bind_dir40 = new BindDirection(_flow.DataFetchActivity12,binding_getter40,binding_setter40,BindTargetType.ToInProperty);
            _flow.DataExporterActivity14.InDirections.Add(bind_dir40);
            this.Activities.Add (_flow.DataExporterActivity14);
            _flow.DataExporterCloseActivity15.Comment = @"";
            _flow.DataExporterCloseActivity15.IconPath = @"";
            this.Activities.Add (_flow.DataExporterCloseActivity15);
            _flow.EndActivity3.Comment = @"";
            _flow.EndActivity3.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.EndActivity3.Name = @"End";
            this.Activities.Add (_flow.EndActivity3);
            _flow.DataDisconnectActivity10.Comment = @"";
            _flow.DataDisconnectActivity10.IconPath = @"";
            VTDPropertyInfoBase pi81 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter41 = new VTDObjectGetter(pi81);
            VTDPropertyInfoBase pi82 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter41 = new VTDObjectSetter(pi82);
            binding_setter41 = new StringFormaterDecorator(binding_setter41,"{Step.DataFetchActivity9.OutTable}");
            bind_dir41 = new BindDirection(_flow.DataFetchActivity9,binding_getter41,binding_setter41,BindTargetType.ToInProperty);
            _flow.DataDisconnectActivity10.InDirections.Add(bind_dir41);
            this.Activities.Add (_flow.DataDisconnectActivity10);
            _flow.DataDisconnectActivity13.Comment = @"";
            _flow.DataDisconnectActivity13.IconPath = @"";
            VTDPropertyInfoBase pi83 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter42 = new VTDObjectGetter(pi83);
            VTDPropertyInfoBase pi84 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter42 = new VTDObjectSetter(pi84);
            binding_setter42 = new StringFormaterDecorator(binding_setter42,"{Step.DataFetchActivity12.OutTable}");
            bind_dir42 = new BindDirection(_flow.DataFetchActivity12,binding_getter42,binding_setter42,BindTargetType.ToInProperty);
            _flow.DataDisconnectActivity13.InDirections.Add(bind_dir42);
            this.Activities.Add (_flow.DataDisconnectActivity13);
            this.DataCursorActivity16.Comment = @"";
            this.DataCursorActivity16.IconPath = @"";
            VTDPropertyInfoBase pi85 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter43 = new VTDObjectGetter(pi85);
            VTDPropertyInfoBase pi86 = new VTDPropertyInfoBase("InTable");
            VTDBaseSetter binding_setter43 = new VTDObjectSetter(pi86);
            binding_setter43 = new StringFormaterDecorator(binding_setter43,"{Step.DataFetchActivity9.OutTable}");
            bind_dir43 = new BindDirection(_flow.DataFetchActivity9,binding_getter43,binding_setter43,BindTargetType.ToInProperty);
            this.DataCursorActivity16.InDirections.Add(bind_dir43);
            this.DataCursorActivity16_Policy.StartPosition = CursorStartPosition.UserSpecificRecord;
            this.DataCursorActivity16_Policy.StartAtSpecificRow = 2;
            this.DataCursorActivity16_Policy.EndPosition = CursorEndPosition.LastRecord;
            this.DataCursorActivity16_Policy.EndAtSpecificRow = 8;
            this.DataCursorActivity16_Policy.StepType = CursorStepType.Forward;
            this.DataCursorActivity16_Policy.StepSize = 2;
            this.DataCursorActivity16_Policy.ActionAfterLastRecord = CursorActionAfterLastRecord.Stay;
            this.DataCursorActivity16.Policy = this.DataCursorActivity16_Policy;
            this.DataCursorActivity16.ReportStepData = true;
            _flow.Loop2.BeforeExecuteStepEvent += this.DataCursorActivity16.ResetCursor;
            _flow.Sequence8.Comment = @"";
            _flow.Sequence8.IconPath = @"";
            _flow.Sequence8.Name = @"Sequence8";
            _flow.Sequence8.Activities.Add (_flow.StServiceCallActivity4);
            _flow.Sequence8.Activities.Add (_flow.StServiceCallActivity7);
            XmlDocument StServiceCallActivity4_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity4_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity4_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><GetFlights xmlns=""HP.SOAQ.SampleApp""><DepartureCity>{DataSource.CityPairs!Input.DepartureCity}</DepartureCity><ArrivalCity>{DataSource.CityPairs!Input.ArrivalCity}</ArrivalCity><FlightDate>2026-10-15T00:00:00+02:00</FlightDate></GetFlights></Body></Envelope>");
            _flow.StServiceCallActivity4.InputEnvelope = StServiceCallActivity4_InputEnvelope_Document;
            _flow.StServiceCallActivity4.Comment = @"";
            _flow.StServiceCallActivity4.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity4.Name = @"GetFlights";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/GetFlights";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity4.Service = @"Flights_Service";
            _flow.StServiceCallActivity4.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity4.Operation = @"GetFlights";
            _flow.StServiceCallActivity4.IsOneWay = false;
            _flow.StServiceCallActivity4.SendRequestToService=true;
            _flow.StServiceCallActivity4.FaultExpected=false;
            _flow.StServiceCallActivity4.IsAsync=false;
            _flow.StServiceCallActivity4.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity4.ListenOnPort = (int)0;
            VTDPropertyInfoBase pi87 = new VTDPropertyInfoBase("DepartureCity");
            VTDBaseGetter binding_getter44 = new VTDObjectGetter(pi87);
            VTDPropertyInfoBase pi88 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlights'][1]/*[local-name(.)='DepartureCity'][1]");
            VTDBaseSetter binding_setter44 = new VTDXPathSetter(pi88,XmlTypeCode.String);
            binding_setter44 = new StringFormaterDecorator(binding_setter44,"{DataSource.CityPairs!Input.DepartureCity}");
            bind_dir44 = new BindDirection(this.DataCursorActivity16,binding_getter44,binding_setter44,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity4.InDirections.Add(bind_dir44);
            VTDPropertyInfoBase pi89 = new VTDPropertyInfoBase("ArrivalCity");
            VTDBaseGetter binding_getter45 = new VTDObjectGetter(pi89);
            VTDPropertyInfoBase pi90 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlights'][1]/*[local-name(.)='ArrivalCity'][1]");
            VTDBaseSetter binding_setter45 = new VTDXPathSetter(pi90,XmlTypeCode.String);
            binding_setter45 = new StringFormaterDecorator(binding_setter45,"{DataSource.CityPairs!Input.ArrivalCity}");
            bind_dir45 = new BindDirection(this.DataCursorActivity16,binding_getter45,binding_setter45,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity4.InDirections.Add(bind_dir45);
            XmlDocument StServiceCallActivity4_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity4.ExpectedOutputAttachments = StServiceCallActivity4_ExpectedOutputAttachments_Document;
            XmlDocument StServiceCallActivity4_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity4.ExpectedFaultProperties = StServiceCallActivity4_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity4_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><GetFlightsResponse xmlns=""HP.SOAQ.SampleApp""><GetFlightsResult><Flight><Airline p1:nil=""true"" /><ArrivalCity p1:nil=""true"" /><ArrivalTime p1:nil=""true"" /><DepartureCity p1:nil=""true"" /><DepartureTime p1:nil=""true"" /><FlightNumber /></Flight></GetFlightsResult></GetFlightsResponse></Body></Envelope>");
            _flow.StServiceCallActivity4.ExpectedOutputProperties = StServiceCallActivity4_ExpectedOutputProperties_Document;
            set_StServiceCallActivity4_checkpoints(_flow.StServiceCallActivity4);
            XmlDocument StServiceCallActivity7_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity7_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity7_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><CreateFlightOrder xmlns=""HP.SOAQ.SampleApp""><FlightOrder><Class>Business</Class><CustomerName>Bill Nye</CustomerName><DepartureDate>{Step.InputProperties.StServiceCallActivity4.Body.GetFlights.FlightDate}</DepartureDate><FlightNumber>{Step.OutputProperties.StServiceCallActivity4.Body.GetFlightsResponse.GetFlightsResult.Flight[1].FlightNumber}</FlightNumber><NumberOfTickets>3</NumberOfTickets></FlightOrder></CreateFlightOrder></Body></Envelope>");
            _flow.StServiceCallActivity7.InputEnvelope = StServiceCallActivity7_InputEnvelope_Document;
            _flow.StServiceCallActivity7.Comment = @"";
            _flow.StServiceCallActivity7.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity7.Name = @"CreateFlightOrder";
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity7.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity7.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/CreateFlightOrder";
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity7.Service = @"Flights_Service";
            _flow.StServiceCallActivity7.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity7.Operation = @"CreateFlightOrder";
            _flow.StServiceCallActivity7.IsOneWay = false;
            _flow.StServiceCallActivity7.SendRequestToService=true;
            _flow.StServiceCallActivity7.FaultExpected=false;
            _flow.StServiceCallActivity7.IsAsync=false;
            _flow.StServiceCallActivity7.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity7.ListenOnPort = (int)0;
            VTDPropertyInfoBase pi91 = new VTDPropertyInfoBase("OutputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlightsResponse'][1]/*[local-name(.)='GetFlightsResult'][1]/*[local-name(.)='Flight'][{Array0}]/*[local-name(.)='FlightNumber'][1]");
            VTDBaseGetter binding_getter46 = new VTDXPathGetter(pi91,XmlTypeCode.Int);
            binding_getter46 = new XPathGetterDecorator(binding_getter46,"{Array0}",1);
            VTDPropertyInfoBase pi92 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='CreateFlightOrder'][1]/*[local-name(.)='FlightOrder'][1]/*[local-name(.)='FlightNumber'][1]");
            VTDBaseSetter binding_setter46 = new VTDXPathSetter(pi92,XmlTypeCode.Int);
            bind_dir46 = new BindDirection(_flow.StServiceCallActivity4,binding_getter46,binding_setter46,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity7.InDirections.Add(bind_dir46);
            VTDPropertyInfoBase pi93 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlights'][1]/*[local-name(.)='FlightDate'][1]");
            VTDBaseGetter binding_getter47 = new VTDXPathGetter(pi93,XmlTypeCode.DateTime);
            VTDPropertyInfoBase pi94 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='CreateFlightOrder'][1]/*[local-name(.)='FlightOrder'][1]/*[local-name(.)='DepartureDate'][1]");
            VTDBaseSetter binding_setter47 = new VTDXPathSetter(pi94,XmlTypeCode.DateTime);
            bind_dir47 = new BindDirection(_flow.StServiceCallActivity4,binding_getter47,binding_setter47,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity7.InDirections.Add(bind_dir47);
            XmlDocument StServiceCallActivity7_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity7_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity7_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity7.ExpectedOutputAttachments = StServiceCallActivity7_ExpectedOutputAttachments_Document;
            XmlDocument StServiceCallActivity7_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity7_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity7_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity7.ExpectedFaultProperties = StServiceCallActivity7_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity7_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity7_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity7_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><CreateFlightOrderResponse xmlns=""HP.SOAQ.SampleApp""><CreateFlightOrderResult><OrderNumber>90</OrderNumber><TotalPrice>300</TotalPrice></CreateFlightOrderResult></CreateFlightOrderResponse></Body></Envelope>");
            _flow.StServiceCallActivity7.ExpectedOutputProperties = StServiceCallActivity7_ExpectedOutputProperties_Document;
            set_StServiceCallActivity7_checkpoints(_flow.StServiceCallActivity7);
            
        }
        
        internal void InitializeEncryptionManagerValues()
        {
        
        }
        	
    	bool useReport = true;
    
    	protected override STExecutionResult ExecuteStep()
        {
            return base.ExecuteStep();
        }
    
        public void Start()
        {
    	    try
    		{
    		  Workflow_Executing();
    		  this.ExecuteStep();
    		}
    		finally
    		{
    		  WorkFlowScript_Completed();
    		}
        }
    
    	private void InitReport()
    	{
    		if (useReport)
    		{	
    			// Intialize Reporter
    			string reportDBDir = Path.Combine(this._context.ReportDirectory, @"Report");
    			CleanupReport(reportDBDir);        	
    			string reportDBPath = Path.Combine(reportDBDir, "VTDReport.mdb");        	
    			if (reporter == null)
    			{
    				reporter = new Reporter(reportDBPath);
    			}
    			_context.Reporter = reporter;
    		}
    	}
    
        public static void CopyDirectory(string Src, string Dst)
        {
            String[] Files;
    
            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
                Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            Files = Directory.GetFileSystemEntries(Src);
            foreach (string Element in Files)
            {
                // Sub directories
                if (Directory.Exists(Element))
                    CopyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);
            }
        }
        
        private void CleanupReport(string reportDBDir)
        {   
    		if (useReport)
    		{             
    			string reportTemplateDir = Path.Combine(ServiceTestRunner.GetInstallPath(),@"bin\ReportResources");                
    			try
    			{
            		CopyDirectory(reportTemplateDir, reportDBDir);
    			}
    			catch //(Exception ex)
    			{
    				//ToDo: LoggingService.Warn("Report Cleanup Error", ex);
    			}
    		}
        }
    
        void Workflow_Executing()
        {   
        	InitReportNode();
                       
        }
    
    	private void InitReportNode()
    	{
    		if (useReport)
    		{	
        		// Init report creator
    			this.reportCreator = new HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator();
    			this.reportLevelInTree = reportCreator.Init(_context.EnvironmentProfile.GetVariableValue("TestName"), _context);
                
    			STActivityBase activity = this;
    			string workflowID = activity.GetHashCode().ToString();
    			ReportNodeCreationData newNodeData =
    			new ReportNodeCreationData(workflowID, workflowID, DateTime.Now);
    			reporter.CreateReportNode(newNodeData);
            
    			ReportInfoData newReportData = new ReportInfoData(workflowID, ReportKeywords.TypeKeywordTag, this.GetType().ToString());
    			reporter.SendReportData(newReportData);
    			newReportData = new ReportInfoData(workflowID, ReportKeywords.NameKeywordTag, this.Name);
    			//TrackData(ReportInfoData.InfoDataTag, newReportData);
    			reporter.SendReportData(newReportData);            
            }
    	}
        
        void WorkFlowScript_Completed()
        {   
    		
    
    		CreateReportFiles();
    					
        	// Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
    
    		OnExecutionCompleted();
    		
        }
    
    	private void CreateReportFiles()
    	{
    		if (useReport)
    		{	
    			//Dispose reporter inorder to close connection to report DB
           		this._context.Reporter.Dispose();
            	
           		// Run report creator
    			reportCreator.RunOnDBAndCreateFiles();
    		}
    	}
    
        
        void Workflow_Faulting()
        {
    		
    
    		CreateReportFiles();
            // Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
           
    		OnExecutionCompleted();
        }
    
    	protected override QcSystemVariables GetRuntimeQcVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeQcVariables(this._context);
    	}
            
    	protected override TestSystemVariables GetTestSystemVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeTestVariables(this._context);
    	}
    
    	private void UpdateTestSettings(ISTRunTimeContext ctx)
        {
    		ctx.PropertyBag["StopTestOnStepFailure"] = true;
    	}
    }
    
    public partial class VuserClass
    {
    	public static string[] CommandLineArguments;
    	public static string[] DotNetResolverPaths;
    	
        public VuserClass()
        {
    				
    		AssemblyResolver.AddSTPathsToResolutionPaths();
    		AssemblyResolver.AttachToAppdomain();
        }
    
        private void AddAssemblyResolver()
        {
    		AssemblyResolver.AddTestPathToResolutionPaths(GetTestPath());
    		AssemblyResolver.AddPathsForAssemblyResolution(DotNetResolverPaths);
        }
    	
        public int STAction()
        {	
            AddAssemblyResolver();
            STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
            WorkFlowScript script = new WorkFlowScript(ctx);
            script.InitializeComponent();
            script.Start();       
            
            return 0;
        }
        
        public void NotifyLicenseException(string msg)
        {
        		
    		try
    		{
    		    STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
                WorkFlowScript script = new WorkFlowScript(ctx);
                script.InitializeComponent();
                script.Context.ReplayClient.OnLicenseFailure(msg);
                
            }
            catch (Exception)
            {
    			// ToDo: log the error message
            }        
        }
    
    	 protected string GetTestPath()
            {
                if (CommandLineArguments != null)
                {
                    for (int i = 0; i < CommandLineArguments.Length; i++)
                    {
                        if (CommandLineArguments[i].Equals("-test", StringComparison.OrdinalIgnoreCase))
                        {
                            return CommandLineArguments[i + 1];
                        }
                    }
                }
                return String.Empty;
            }
        
    }
    
    }
    