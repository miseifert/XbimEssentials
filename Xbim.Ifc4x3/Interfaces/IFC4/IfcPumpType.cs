// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.HvacDomain
{
	public partial class @IfcPumpType : IIfcPumpType
	{

		[CrossSchemaAttribute(typeof(IIfcPumpType), 10)]
		Ifc4.Interfaces.IfcPumpTypeEnum IIfcPumpType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcPumpTypeEnum.CIRCULATOR:
						return Ifc4.Interfaces.IfcPumpTypeEnum.CIRCULATOR;
					case IfcPumpTypeEnum.ENDSUCTION:
						return Ifc4.Interfaces.IfcPumpTypeEnum.ENDSUCTION;
					case IfcPumpTypeEnum.SPLITCASE:
						return Ifc4.Interfaces.IfcPumpTypeEnum.SPLITCASE;
					case IfcPumpTypeEnum.SUBMERSIBLEPUMP:
						return Ifc4.Interfaces.IfcPumpTypeEnum.SUBMERSIBLEPUMP;
					case IfcPumpTypeEnum.SUMPPUMP:
						return Ifc4.Interfaces.IfcPumpTypeEnum.SUMPPUMP;
					case IfcPumpTypeEnum.VERTICALINLINE:
						return Ifc4.Interfaces.IfcPumpTypeEnum.VERTICALINLINE;
					case IfcPumpTypeEnum.VERTICALTURBINE:
						return Ifc4.Interfaces.IfcPumpTypeEnum.VERTICALTURBINE;
					case IfcPumpTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcPumpTypeEnum.USERDEFINED;
					case IfcPumpTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcPumpTypeEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcPumpTypeEnum.CIRCULATOR:
						PredefinedType = IfcPumpTypeEnum.CIRCULATOR;
						return;
					case Ifc4.Interfaces.IfcPumpTypeEnum.ENDSUCTION:
						PredefinedType = IfcPumpTypeEnum.ENDSUCTION;
						return;
					case Ifc4.Interfaces.IfcPumpTypeEnum.SPLITCASE:
						PredefinedType = IfcPumpTypeEnum.SPLITCASE;
						return;
					case Ifc4.Interfaces.IfcPumpTypeEnum.SUBMERSIBLEPUMP:
						PredefinedType = IfcPumpTypeEnum.SUBMERSIBLEPUMP;
						return;
					case Ifc4.Interfaces.IfcPumpTypeEnum.SUMPPUMP:
						PredefinedType = IfcPumpTypeEnum.SUMPPUMP;
						return;
					case Ifc4.Interfaces.IfcPumpTypeEnum.VERTICALINLINE:
						PredefinedType = IfcPumpTypeEnum.VERTICALINLINE;
						return;
					case Ifc4.Interfaces.IfcPumpTypeEnum.VERTICALTURBINE:
						PredefinedType = IfcPumpTypeEnum.VERTICALTURBINE;
						return;
					case Ifc4.Interfaces.IfcPumpTypeEnum.USERDEFINED:
						PredefinedType = IfcPumpTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcPumpTypeEnum.NOTDEFINED:
						PredefinedType = IfcPumpTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}