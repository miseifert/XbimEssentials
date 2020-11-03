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
namespace Xbim.Ifc4x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralSurfaceAction : IIfcStructuralSurfaceAction
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralSurfaceAction), 11)]
		Ifc4.Interfaces.IfcProjectedOrTrueLengthEnum? IIfcStructuralSurfaceAction.ProjectedOrTrue 
		{ 
			get
			{
				//## Custom code to handle enumeration of ProjectedOrTrue
				//##
				switch (ProjectedOrTrue)
				{
					case IfcProjectedOrTrueLengthEnum.PROJECTED_LENGTH:
						return Ifc4.Interfaces.IfcProjectedOrTrueLengthEnum.PROJECTED_LENGTH;
					case IfcProjectedOrTrueLengthEnum.TRUE_LENGTH:
						return Ifc4.Interfaces.IfcProjectedOrTrueLengthEnum.TRUE_LENGTH;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of ProjectedOrTrue
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcProjectedOrTrueLengthEnum.PROJECTED_LENGTH:
						ProjectedOrTrue = IfcProjectedOrTrueLengthEnum.PROJECTED_LENGTH;
						return;
					case Ifc4.Interfaces.IfcProjectedOrTrueLengthEnum.TRUE_LENGTH:
						ProjectedOrTrue = IfcProjectedOrTrueLengthEnum.TRUE_LENGTH;
						return;
					
					case null:
						ProjectedOrTrue = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralSurfaceAction), 12)]
		Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum IIfcStructuralSurfaceAction.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcStructuralSurfaceActivityTypeEnum.CONST:
						return Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum.CONST;
					case IfcStructuralSurfaceActivityTypeEnum.BILINEAR:
						return Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum.BILINEAR;
					case IfcStructuralSurfaceActivityTypeEnum.DISCRETE:
						return Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum.DISCRETE;
					case IfcStructuralSurfaceActivityTypeEnum.ISOCONTOUR:
						return Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum.ISOCONTOUR;
					case IfcStructuralSurfaceActivityTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum.USERDEFINED;
					case IfcStructuralSurfaceActivityTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum.CONST:
						PredefinedType = IfcStructuralSurfaceActivityTypeEnum.CONST;
						return;
					case Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum.BILINEAR:
						PredefinedType = IfcStructuralSurfaceActivityTypeEnum.BILINEAR;
						return;
					case Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum.DISCRETE:
						PredefinedType = IfcStructuralSurfaceActivityTypeEnum.DISCRETE;
						return;
					case Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum.ISOCONTOUR:
						PredefinedType = IfcStructuralSurfaceActivityTypeEnum.ISOCONTOUR;
						return;
					case Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum.USERDEFINED:
						PredefinedType = IfcStructuralSurfaceActivityTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum.NOTDEFINED:
						PredefinedType = IfcStructuralSurfaceActivityTypeEnum.NOTDEFINED;
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