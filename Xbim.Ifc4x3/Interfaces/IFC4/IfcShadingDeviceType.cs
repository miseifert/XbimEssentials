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
namespace Xbim.Ifc4x3.SharedBldgElements
{
	public partial class @IfcShadingDeviceType : IIfcShadingDeviceType
	{

		[CrossSchemaAttribute(typeof(IIfcShadingDeviceType), 10)]
		Ifc4.Interfaces.IfcShadingDeviceTypeEnum IIfcShadingDeviceType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcShadingDeviceTypeEnum.JALOUSIE:
						return Ifc4.Interfaces.IfcShadingDeviceTypeEnum.JALOUSIE;
					case IfcShadingDeviceTypeEnum.SHUTTER:
						return Ifc4.Interfaces.IfcShadingDeviceTypeEnum.SHUTTER;
					case IfcShadingDeviceTypeEnum.AWNING:
						return Ifc4.Interfaces.IfcShadingDeviceTypeEnum.AWNING;
					case IfcShadingDeviceTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcShadingDeviceTypeEnum.USERDEFINED;
					case IfcShadingDeviceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcShadingDeviceTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcShadingDeviceTypeEnum.JALOUSIE:
						PredefinedType = IfcShadingDeviceTypeEnum.JALOUSIE;
						return;
					case Ifc4.Interfaces.IfcShadingDeviceTypeEnum.SHUTTER:
						PredefinedType = IfcShadingDeviceTypeEnum.SHUTTER;
						return;
					case Ifc4.Interfaces.IfcShadingDeviceTypeEnum.AWNING:
						PredefinedType = IfcShadingDeviceTypeEnum.AWNING;
						return;
					case Ifc4.Interfaces.IfcShadingDeviceTypeEnum.USERDEFINED:
						PredefinedType = IfcShadingDeviceTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcShadingDeviceTypeEnum.NOTDEFINED:
						PredefinedType = IfcShadingDeviceTypeEnum.NOTDEFINED;
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