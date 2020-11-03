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
	public partial class @IfcTank : IIfcTank
	{

		[CrossSchemaAttribute(typeof(IIfcTank), 9)]
		Ifc4.Interfaces.IfcTankTypeEnum? IIfcTank.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcTankTypeEnum.BASIN:
						return Ifc4.Interfaces.IfcTankTypeEnum.BASIN;
					case IfcTankTypeEnum.BREAKPRESSURE:
						return Ifc4.Interfaces.IfcTankTypeEnum.BREAKPRESSURE;
					case IfcTankTypeEnum.EXPANSION:
						return Ifc4.Interfaces.IfcTankTypeEnum.EXPANSION;
					case IfcTankTypeEnum.FEEDANDEXPANSION:
						return Ifc4.Interfaces.IfcTankTypeEnum.FEEDANDEXPANSION;
					case IfcTankTypeEnum.PRESSUREVESSEL:
						return Ifc4.Interfaces.IfcTankTypeEnum.PRESSUREVESSEL;
					case IfcTankTypeEnum.STORAGE:
						return Ifc4.Interfaces.IfcTankTypeEnum.STORAGE;
					case IfcTankTypeEnum.VESSEL:
						return Ifc4.Interfaces.IfcTankTypeEnum.VESSEL;
					case IfcTankTypeEnum.OILRETENTIONTRAY:
						//## Handle translation of OILRETENTIONTRAY member from IfcTankTypeEnum in property PredefinedType
						//TODO: Handle translation of OILRETENTIONTRAY member from IfcTankTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcTankTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcTankTypeEnum.USERDEFINED;
					case IfcTankTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcTankTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcTankTypeEnum.BASIN:
						PredefinedType = IfcTankTypeEnum.BASIN;
						return;
					case Ifc4.Interfaces.IfcTankTypeEnum.BREAKPRESSURE:
						PredefinedType = IfcTankTypeEnum.BREAKPRESSURE;
						return;
					case Ifc4.Interfaces.IfcTankTypeEnum.EXPANSION:
						PredefinedType = IfcTankTypeEnum.EXPANSION;
						return;
					case Ifc4.Interfaces.IfcTankTypeEnum.FEEDANDEXPANSION:
						PredefinedType = IfcTankTypeEnum.FEEDANDEXPANSION;
						return;
					case Ifc4.Interfaces.IfcTankTypeEnum.PRESSUREVESSEL:
						PredefinedType = IfcTankTypeEnum.PRESSUREVESSEL;
						return;
					case Ifc4.Interfaces.IfcTankTypeEnum.STORAGE:
						PredefinedType = IfcTankTypeEnum.STORAGE;
						return;
					case Ifc4.Interfaces.IfcTankTypeEnum.VESSEL:
						PredefinedType = IfcTankTypeEnum.VESSEL;
						return;
					case Ifc4.Interfaces.IfcTankTypeEnum.USERDEFINED:
						PredefinedType = IfcTankTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcTankTypeEnum.NOTDEFINED:
						PredefinedType = IfcTankTypeEnum.NOTDEFINED;
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