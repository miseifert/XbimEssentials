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
namespace Xbim.Ifc4x3.MaterialResource
{
	public partial class @IfcMaterialProfileSetUsage : IIfcMaterialProfileSetUsage
	{

		[CrossSchemaAttribute(typeof(IIfcMaterialProfileSetUsage), 1)]
		IIfcMaterialProfileSet IIfcMaterialProfileSetUsage.ForProfileSet 
		{ 
			get
			{
				return ForProfileSet;
			} 
			set
			{
				ForProfileSet = value as IfcMaterialProfileSet;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcMaterialProfileSetUsage), 2)]
		Ifc4.MaterialResource.IfcCardinalPointReference? IIfcMaterialProfileSetUsage.CardinalPoint 
		{ 
			get
			{
				if (!CardinalPoint.HasValue) return null;
				return new Ifc4.MaterialResource.IfcCardinalPointReference(CardinalPoint.Value);
			} 
			set
			{
				CardinalPoint = value.HasValue ? 
					new IfcCardinalPointReference(value.Value) :  
					 new IfcCardinalPointReference?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcMaterialProfileSetUsage), 3)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcMaterialProfileSetUsage.ReferenceExtent 
		{ 
			get
			{
				if (!ReferenceExtent.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(ReferenceExtent.Value);
			} 
			set
			{
				ReferenceExtent = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}