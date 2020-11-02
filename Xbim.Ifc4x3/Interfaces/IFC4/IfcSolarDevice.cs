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
namespace Xbim.Ifc4x3.ElectricalDomain
{
	public partial class @IfcSolarDevice : IIfcSolarDevice
	{

		[CrossSchemaAttribute(typeof(IIfcSolarDevice), 9)]
		Ifc4.Interfaces.IfcSolarDeviceTypeEnum? IIfcSolarDevice.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcSolarDeviceTypeEnum.SOLARCOLLECTOR:
						return Ifc4.Interfaces.IfcSolarDeviceTypeEnum.SOLARCOLLECTOR;
					case IfcSolarDeviceTypeEnum.SOLARPANEL:
						return Ifc4.Interfaces.IfcSolarDeviceTypeEnum.SOLARPANEL;
					case IfcSolarDeviceTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcSolarDeviceTypeEnum.USERDEFINED;
					case IfcSolarDeviceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcSolarDeviceTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcSolarDeviceTypeEnum.SOLARCOLLECTOR:
						PredefinedType = IfcSolarDeviceTypeEnum.SOLARCOLLECTOR;
						return;
					case Ifc4.Interfaces.IfcSolarDeviceTypeEnum.SOLARPANEL:
						PredefinedType = IfcSolarDeviceTypeEnum.SOLARPANEL;
						return;
					case Ifc4.Interfaces.IfcSolarDeviceTypeEnum.USERDEFINED:
						PredefinedType = IfcSolarDeviceTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcSolarDeviceTypeEnum.NOTDEFINED:
						PredefinedType = IfcSolarDeviceTypeEnum.NOTDEFINED;
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