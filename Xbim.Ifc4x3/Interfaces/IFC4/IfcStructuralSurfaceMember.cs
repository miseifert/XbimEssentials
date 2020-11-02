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
namespace Xbim.Ifc4x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralSurfaceMember : IIfcStructuralSurfaceMember
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralSurfaceMember), 8)]
		Ifc4.Interfaces.IfcStructuralSurfaceMemberTypeEnum IIfcStructuralSurfaceMember.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcStructuralSurfaceMemberTypeEnum.BENDING_ELEMENT:
						return Ifc4.Interfaces.IfcStructuralSurfaceMemberTypeEnum.BENDING_ELEMENT;
					case IfcStructuralSurfaceMemberTypeEnum.MEMBRANE_ELEMENT:
						return Ifc4.Interfaces.IfcStructuralSurfaceMemberTypeEnum.MEMBRANE_ELEMENT;
					case IfcStructuralSurfaceMemberTypeEnum.SHELL:
						return Ifc4.Interfaces.IfcStructuralSurfaceMemberTypeEnum.SHELL;
					case IfcStructuralSurfaceMemberTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcStructuralSurfaceMemberTypeEnum.USERDEFINED;
					case IfcStructuralSurfaceMemberTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcStructuralSurfaceMemberTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcStructuralSurfaceMemberTypeEnum.BENDING_ELEMENT:
						PredefinedType = IfcStructuralSurfaceMemberTypeEnum.BENDING_ELEMENT;
						return;
					case Ifc4.Interfaces.IfcStructuralSurfaceMemberTypeEnum.MEMBRANE_ELEMENT:
						PredefinedType = IfcStructuralSurfaceMemberTypeEnum.MEMBRANE_ELEMENT;
						return;
					case Ifc4.Interfaces.IfcStructuralSurfaceMemberTypeEnum.SHELL:
						PredefinedType = IfcStructuralSurfaceMemberTypeEnum.SHELL;
						return;
					case Ifc4.Interfaces.IfcStructuralSurfaceMemberTypeEnum.USERDEFINED:
						PredefinedType = IfcStructuralSurfaceMemberTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcStructuralSurfaceMemberTypeEnum.NOTDEFINED:
						PredefinedType = IfcStructuralSurfaceMemberTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralSurfaceMember), 9)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcStructuralSurfaceMember.Thickness 
		{ 
			get
			{
				if (!Thickness.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(Thickness.Value);
			} 
			set
			{
				Thickness = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}