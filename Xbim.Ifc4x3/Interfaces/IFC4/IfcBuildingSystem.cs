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
	public partial class @IfcBuildingSystem : IIfcBuildingSystem
	{

		[CrossSchemaAttribute(typeof(IIfcBuildingSystem), 6)]
		Ifc4.Interfaces.IfcBuildingSystemTypeEnum? IIfcBuildingSystem.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcBuildingSystemTypeEnum.FENESTRATION:
						return Ifc4.Interfaces.IfcBuildingSystemTypeEnum.FENESTRATION;
					case IfcBuildingSystemTypeEnum.FOUNDATION:
						return Ifc4.Interfaces.IfcBuildingSystemTypeEnum.FOUNDATION;
					case IfcBuildingSystemTypeEnum.LOADBEARING:
						return Ifc4.Interfaces.IfcBuildingSystemTypeEnum.LOADBEARING;
					case IfcBuildingSystemTypeEnum.OUTERSHELL:
						return Ifc4.Interfaces.IfcBuildingSystemTypeEnum.OUTERSHELL;
					case IfcBuildingSystemTypeEnum.SHADING:
						return Ifc4.Interfaces.IfcBuildingSystemTypeEnum.SHADING;
					case IfcBuildingSystemTypeEnum.TRANSPORT:
						return Ifc4.Interfaces.IfcBuildingSystemTypeEnum.TRANSPORT;
					case IfcBuildingSystemTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcBuildingSystemTypeEnum.USERDEFINED;
					case IfcBuildingSystemTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcBuildingSystemTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcBuildingSystemTypeEnum.FENESTRATION:
						PredefinedType = IfcBuildingSystemTypeEnum.FENESTRATION;
						return;
					case Ifc4.Interfaces.IfcBuildingSystemTypeEnum.FOUNDATION:
						PredefinedType = IfcBuildingSystemTypeEnum.FOUNDATION;
						return;
					case Ifc4.Interfaces.IfcBuildingSystemTypeEnum.LOADBEARING:
						PredefinedType = IfcBuildingSystemTypeEnum.LOADBEARING;
						return;
					case Ifc4.Interfaces.IfcBuildingSystemTypeEnum.OUTERSHELL:
						PredefinedType = IfcBuildingSystemTypeEnum.OUTERSHELL;
						return;
					case Ifc4.Interfaces.IfcBuildingSystemTypeEnum.SHADING:
						PredefinedType = IfcBuildingSystemTypeEnum.SHADING;
						return;
					case Ifc4.Interfaces.IfcBuildingSystemTypeEnum.TRANSPORT:
						PredefinedType = IfcBuildingSystemTypeEnum.TRANSPORT;
						return;
					case Ifc4.Interfaces.IfcBuildingSystemTypeEnum.USERDEFINED:
						PredefinedType = IfcBuildingSystemTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcBuildingSystemTypeEnum.NOTDEFINED:
						PredefinedType = IfcBuildingSystemTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBuildingSystem), 7)]
		Ifc4.MeasureResource.IfcLabel? IIfcBuildingSystem.LongName 
		{ 
			get
			{
				if (!LongName.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(LongName.Value);
			} 
			set
			{
				LongName = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
	//##
	}
}