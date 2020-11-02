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
namespace Xbim.Ifc4x3.SharedBldgElements
{
	public partial class @IfcRampFlight : IIfcRampFlight
	{

		[CrossSchemaAttribute(typeof(IIfcRampFlight), 9)]
		Ifc4.Interfaces.IfcRampFlightTypeEnum? IIfcRampFlight.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcRampFlightTypeEnum.STRAIGHT:
						return Ifc4.Interfaces.IfcRampFlightTypeEnum.STRAIGHT;
					case IfcRampFlightTypeEnum.SPIRAL:
						return Ifc4.Interfaces.IfcRampFlightTypeEnum.SPIRAL;
					case IfcRampFlightTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcRampFlightTypeEnum.USERDEFINED;
					case IfcRampFlightTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcRampFlightTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcRampFlightTypeEnum.STRAIGHT:
						PredefinedType = IfcRampFlightTypeEnum.STRAIGHT;
						return;
					case Ifc4.Interfaces.IfcRampFlightTypeEnum.SPIRAL:
						PredefinedType = IfcRampFlightTypeEnum.SPIRAL;
						return;
					case Ifc4.Interfaces.IfcRampFlightTypeEnum.USERDEFINED:
						PredefinedType = IfcRampFlightTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcRampFlightTypeEnum.NOTDEFINED:
						PredefinedType = IfcRampFlightTypeEnum.NOTDEFINED;
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