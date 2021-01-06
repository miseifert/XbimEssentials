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
	public partial class @IfcChiller : IIfcChiller
	{

		[CrossSchemaAttribute(typeof(IIfcChiller), 9)]
		Ifc4.Interfaces.IfcChillerTypeEnum? IIfcChiller.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcChillerTypeEnum.AIRCOOLED:
						return Ifc4.Interfaces.IfcChillerTypeEnum.AIRCOOLED;
					case IfcChillerTypeEnum.WATERCOOLED:
						return Ifc4.Interfaces.IfcChillerTypeEnum.WATERCOOLED;
					case IfcChillerTypeEnum.HEATRECOVERY:
						return Ifc4.Interfaces.IfcChillerTypeEnum.HEATRECOVERY;
					case IfcChillerTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcChillerTypeEnum.USERDEFINED;
					case IfcChillerTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcChillerTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcChillerTypeEnum.AIRCOOLED:
						PredefinedType = IfcChillerTypeEnum.AIRCOOLED;
						return;
					case Ifc4.Interfaces.IfcChillerTypeEnum.WATERCOOLED:
						PredefinedType = IfcChillerTypeEnum.WATERCOOLED;
						return;
					case Ifc4.Interfaces.IfcChillerTypeEnum.HEATRECOVERY:
						PredefinedType = IfcChillerTypeEnum.HEATRECOVERY;
						return;
					case Ifc4.Interfaces.IfcChillerTypeEnum.USERDEFINED:
						PredefinedType = IfcChillerTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcChillerTypeEnum.NOTDEFINED:
						PredefinedType = IfcChillerTypeEnum.NOTDEFINED;
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