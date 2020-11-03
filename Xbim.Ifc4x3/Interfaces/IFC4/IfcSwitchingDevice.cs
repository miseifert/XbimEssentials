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

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.ElectricalDomain
{
	public partial class @IfcSwitchingDevice : IIfcSwitchingDevice
	{

		[CrossSchemaAttribute(typeof(IIfcSwitchingDevice), 9)]
		Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum? IIfcSwitchingDevice.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcSwitchingDeviceTypeEnum.CONTACTOR:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.CONTACTOR;
					case IfcSwitchingDeviceTypeEnum.DIMMERSWITCH:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.DIMMERSWITCH;
					case IfcSwitchingDeviceTypeEnum.EMERGENCYSTOP:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.EMERGENCYSTOP;
					case IfcSwitchingDeviceTypeEnum.KEYPAD:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.KEYPAD;
					case IfcSwitchingDeviceTypeEnum.MOMENTARYSWITCH:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.MOMENTARYSWITCH;
					case IfcSwitchingDeviceTypeEnum.SELECTORSWITCH:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.SELECTORSWITCH;
					case IfcSwitchingDeviceTypeEnum.STARTER:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.STARTER;
					case IfcSwitchingDeviceTypeEnum.SWITCHDISCONNECTOR:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.SWITCHDISCONNECTOR;
					case IfcSwitchingDeviceTypeEnum.TOGGLESWITCH:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.TOGGLESWITCH;
					case IfcSwitchingDeviceTypeEnum.RELAY:
						//## Handle translation of RELAY member from IfcSwitchingDeviceTypeEnum in property PredefinedType
						//TODO: Handle translation of RELAY member from IfcSwitchingDeviceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcSwitchingDeviceTypeEnum.START_AND_STOP_EQUIPMENT:
						//## Handle translation of START_AND_STOP_EQUIPMENT member from IfcSwitchingDeviceTypeEnum in property PredefinedType
						//TODO: Handle translation of START_AND_STOP_EQUIPMENT member from IfcSwitchingDeviceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcSwitchingDeviceTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.USERDEFINED;
					case IfcSwitchingDeviceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
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
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.CONTACTOR:
						PredefinedType = IfcSwitchingDeviceTypeEnum.CONTACTOR;
						return;
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.DIMMERSWITCH:
						PredefinedType = IfcSwitchingDeviceTypeEnum.DIMMERSWITCH;
						return;
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.EMERGENCYSTOP:
						PredefinedType = IfcSwitchingDeviceTypeEnum.EMERGENCYSTOP;
						return;
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.KEYPAD:
						PredefinedType = IfcSwitchingDeviceTypeEnum.KEYPAD;
						return;
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.MOMENTARYSWITCH:
						PredefinedType = IfcSwitchingDeviceTypeEnum.MOMENTARYSWITCH;
						return;
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.SELECTORSWITCH:
						PredefinedType = IfcSwitchingDeviceTypeEnum.SELECTORSWITCH;
						return;
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.STARTER:
						PredefinedType = IfcSwitchingDeviceTypeEnum.STARTER;
						return;
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.SWITCHDISCONNECTOR:
						PredefinedType = IfcSwitchingDeviceTypeEnum.SWITCHDISCONNECTOR;
						return;
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.TOGGLESWITCH:
						PredefinedType = IfcSwitchingDeviceTypeEnum.TOGGLESWITCH;
						return;
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.USERDEFINED:
						PredefinedType = IfcSwitchingDeviceTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.NOTDEFINED:
						PredefinedType = IfcSwitchingDeviceTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
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