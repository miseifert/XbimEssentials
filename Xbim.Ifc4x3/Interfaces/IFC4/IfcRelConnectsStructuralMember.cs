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
	public partial class @IfcRelConnectsStructuralMember : IIfcRelConnectsStructuralMember
	{

		[CrossSchemaAttribute(typeof(IIfcRelConnectsStructuralMember), 5)]
		IIfcStructuralMember IIfcRelConnectsStructuralMember.RelatingStructuralMember 
		{ 
			get
			{
				return RelatingStructuralMember;
			} 
			set
			{
				RelatingStructuralMember = value as IfcStructuralMember;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRelConnectsStructuralMember), 6)]
		IIfcStructuralConnection IIfcRelConnectsStructuralMember.RelatedStructuralConnection 
		{ 
			get
			{
				return RelatedStructuralConnection;
			} 
			set
			{
				RelatedStructuralConnection = value as IfcStructuralConnection;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRelConnectsStructuralMember), 7)]
		IIfcBoundaryCondition IIfcRelConnectsStructuralMember.AppliedCondition 
		{ 
			get
			{
				return AppliedCondition;
			} 
			set
			{
				AppliedCondition = value as StructuralLoadResource.IfcBoundaryCondition;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRelConnectsStructuralMember), 8)]
		IIfcStructuralConnectionCondition IIfcRelConnectsStructuralMember.AdditionalConditions 
		{ 
			get
			{
				return AdditionalConditions;
			} 
			set
			{
				AdditionalConditions = value as StructuralLoadResource.IfcStructuralConnectionCondition;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRelConnectsStructuralMember), 9)]
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcRelConnectsStructuralMember.SupportedLength 
		{ 
			get
			{
				if (!SupportedLength.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(SupportedLength.Value);
			} 
			set
			{
				SupportedLength = value.HasValue ? 
					new MeasureResource.IfcLengthMeasure(value.Value) :  
					 new MeasureResource.IfcLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRelConnectsStructuralMember), 10)]
		IIfcAxis2Placement3D IIfcRelConnectsStructuralMember.ConditionCoordinateSystem 
		{ 
			get
			{
				return ConditionCoordinateSystem;
			} 
			set
			{
				ConditionCoordinateSystem = value as GeometryResource.IfcAxis2Placement3D;
				
			}
		}
	//## Custom code
	//##
	}
}