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
namespace Xbim.Ifc4x3.HvacDomain
{
	public partial class @IfcMedicalDeviceType : IIfcMedicalDeviceType
	{

		[CrossSchemaAttribute(typeof(IIfcMedicalDeviceType), 10)]
		Ifc4.Interfaces.IfcMedicalDeviceTypeEnum IIfcMedicalDeviceType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcMedicalDeviceTypeEnum.AIRSTATION:
						return Ifc4.Interfaces.IfcMedicalDeviceTypeEnum.AIRSTATION;
					case IfcMedicalDeviceTypeEnum.FEEDAIRUNIT:
						return Ifc4.Interfaces.IfcMedicalDeviceTypeEnum.FEEDAIRUNIT;
					case IfcMedicalDeviceTypeEnum.OXYGENGENERATOR:
						return Ifc4.Interfaces.IfcMedicalDeviceTypeEnum.OXYGENGENERATOR;
					case IfcMedicalDeviceTypeEnum.OXYGENPLANT:
						return Ifc4.Interfaces.IfcMedicalDeviceTypeEnum.OXYGENPLANT;
					case IfcMedicalDeviceTypeEnum.VACUUMSTATION:
						return Ifc4.Interfaces.IfcMedicalDeviceTypeEnum.VACUUMSTATION;
					case IfcMedicalDeviceTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcMedicalDeviceTypeEnum.USERDEFINED;
					case IfcMedicalDeviceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcMedicalDeviceTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcMedicalDeviceTypeEnum.AIRSTATION:
						PredefinedType = IfcMedicalDeviceTypeEnum.AIRSTATION;
						return;
					case Ifc4.Interfaces.IfcMedicalDeviceTypeEnum.FEEDAIRUNIT:
						PredefinedType = IfcMedicalDeviceTypeEnum.FEEDAIRUNIT;
						return;
					case Ifc4.Interfaces.IfcMedicalDeviceTypeEnum.OXYGENGENERATOR:
						PredefinedType = IfcMedicalDeviceTypeEnum.OXYGENGENERATOR;
						return;
					case Ifc4.Interfaces.IfcMedicalDeviceTypeEnum.OXYGENPLANT:
						PredefinedType = IfcMedicalDeviceTypeEnum.OXYGENPLANT;
						return;
					case Ifc4.Interfaces.IfcMedicalDeviceTypeEnum.VACUUMSTATION:
						PredefinedType = IfcMedicalDeviceTypeEnum.VACUUMSTATION;
						return;
					case Ifc4.Interfaces.IfcMedicalDeviceTypeEnum.USERDEFINED:
						PredefinedType = IfcMedicalDeviceTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcMedicalDeviceTypeEnum.NOTDEFINED:
						PredefinedType = IfcMedicalDeviceTypeEnum.NOTDEFINED;
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