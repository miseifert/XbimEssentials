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
namespace Xbim.Ifc4x3.BuildingControlsDomain
{
	public partial class @IfcActuatorType : IIfcActuatorType
	{

		[CrossSchemaAttribute(typeof(IIfcActuatorType), 10)]
		Ifc4.Interfaces.IfcActuatorTypeEnum IIfcActuatorType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcActuatorTypeEnum.ELECTRICACTUATOR:
						return Ifc4.Interfaces.IfcActuatorTypeEnum.ELECTRICACTUATOR;
					case IfcActuatorTypeEnum.HANDOPERATEDACTUATOR:
						return Ifc4.Interfaces.IfcActuatorTypeEnum.HANDOPERATEDACTUATOR;
					case IfcActuatorTypeEnum.HYDRAULICACTUATOR:
						return Ifc4.Interfaces.IfcActuatorTypeEnum.HYDRAULICACTUATOR;
					case IfcActuatorTypeEnum.PNEUMATICACTUATOR:
						return Ifc4.Interfaces.IfcActuatorTypeEnum.PNEUMATICACTUATOR;
					case IfcActuatorTypeEnum.THERMOSTATICACTUATOR:
						return Ifc4.Interfaces.IfcActuatorTypeEnum.THERMOSTATICACTUATOR;
					case IfcActuatorTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcActuatorTypeEnum.USERDEFINED;
					case IfcActuatorTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcActuatorTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcActuatorTypeEnum.ELECTRICACTUATOR:
						PredefinedType = IfcActuatorTypeEnum.ELECTRICACTUATOR;
						return;
					case Ifc4.Interfaces.IfcActuatorTypeEnum.HANDOPERATEDACTUATOR:
						PredefinedType = IfcActuatorTypeEnum.HANDOPERATEDACTUATOR;
						return;
					case Ifc4.Interfaces.IfcActuatorTypeEnum.HYDRAULICACTUATOR:
						PredefinedType = IfcActuatorTypeEnum.HYDRAULICACTUATOR;
						return;
					case Ifc4.Interfaces.IfcActuatorTypeEnum.PNEUMATICACTUATOR:
						PredefinedType = IfcActuatorTypeEnum.PNEUMATICACTUATOR;
						return;
					case Ifc4.Interfaces.IfcActuatorTypeEnum.THERMOSTATICACTUATOR:
						PredefinedType = IfcActuatorTypeEnum.THERMOSTATICACTUATOR;
						return;
					case Ifc4.Interfaces.IfcActuatorTypeEnum.USERDEFINED:
						PredefinedType = IfcActuatorTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcActuatorTypeEnum.NOTDEFINED:
						PredefinedType = IfcActuatorTypeEnum.NOTDEFINED;
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