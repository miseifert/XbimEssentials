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
	public partial class @IfcLightFixtureType : IIfcLightFixtureType
	{

		[CrossSchemaAttribute(typeof(IIfcLightFixtureType), 10)]
		Ifc4.Interfaces.IfcLightFixtureTypeEnum IIfcLightFixtureType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcLightFixtureTypeEnum.POINTSOURCE:
						return Ifc4.Interfaces.IfcLightFixtureTypeEnum.POINTSOURCE;
					case IfcLightFixtureTypeEnum.DIRECTIONSOURCE:
						return Ifc4.Interfaces.IfcLightFixtureTypeEnum.DIRECTIONSOURCE;
					case IfcLightFixtureTypeEnum.SECURITYLIGHTING:
						return Ifc4.Interfaces.IfcLightFixtureTypeEnum.SECURITYLIGHTING;
					case IfcLightFixtureTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcLightFixtureTypeEnum.USERDEFINED;
					case IfcLightFixtureTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcLightFixtureTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcLightFixtureTypeEnum.POINTSOURCE:
						PredefinedType = IfcLightFixtureTypeEnum.POINTSOURCE;
						return;
					case Ifc4.Interfaces.IfcLightFixtureTypeEnum.DIRECTIONSOURCE:
						PredefinedType = IfcLightFixtureTypeEnum.DIRECTIONSOURCE;
						return;
					case Ifc4.Interfaces.IfcLightFixtureTypeEnum.SECURITYLIGHTING:
						PredefinedType = IfcLightFixtureTypeEnum.SECURITYLIGHTING;
						return;
					case Ifc4.Interfaces.IfcLightFixtureTypeEnum.USERDEFINED:
						PredefinedType = IfcLightFixtureTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcLightFixtureTypeEnum.NOTDEFINED:
						PredefinedType = IfcLightFixtureTypeEnum.NOTDEFINED;
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