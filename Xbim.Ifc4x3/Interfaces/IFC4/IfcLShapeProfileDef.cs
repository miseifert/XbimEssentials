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
namespace Xbim.Ifc4x3.ProfileResource
{
	public partial class @IfcLShapeProfileDef : IIfcLShapeProfileDef
	{

		[CrossSchemaAttribute(typeof(IIfcLShapeProfileDef), 4)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcLShapeProfileDef.Depth 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(Depth);
			} 
			set
			{
				Depth = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLShapeProfileDef), 5)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcLShapeProfileDef.Width 
		{ 
			get
			{
				if (!Width.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(Width.Value);
			} 
			set
			{
				Width = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLShapeProfileDef), 6)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcLShapeProfileDef.Thickness 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(Thickness);
			} 
			set
			{
				Thickness = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLShapeProfileDef), 7)]
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcLShapeProfileDef.FilletRadius 
		{ 
			get
			{
				if (!FilletRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(FilletRadius.Value);
			} 
			set
			{
				FilletRadius = value.HasValue ? 
					new MeasureResource.IfcNonNegativeLengthMeasure(value.Value) :  
					 new MeasureResource.IfcNonNegativeLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLShapeProfileDef), 8)]
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcLShapeProfileDef.EdgeRadius 
		{ 
			get
			{
				if (!EdgeRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(EdgeRadius.Value);
			} 
			set
			{
				EdgeRadius = value.HasValue ? 
					new MeasureResource.IfcNonNegativeLengthMeasure(value.Value) :  
					 new MeasureResource.IfcNonNegativeLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLShapeProfileDef), 9)]
		Ifc4.MeasureResource.IfcPlaneAngleMeasure? IIfcLShapeProfileDef.LegSlope 
		{ 
			get
			{
				if (!LegSlope.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPlaneAngleMeasure(LegSlope.Value);
			} 
			set
			{
				LegSlope = value.HasValue ? 
					new MeasureResource.IfcPlaneAngleMeasure(value.Value) :  
					 new MeasureResource.IfcPlaneAngleMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}