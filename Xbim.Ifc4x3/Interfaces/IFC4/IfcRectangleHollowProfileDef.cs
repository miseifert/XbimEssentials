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
namespace Xbim.Ifc4x3.ProfileResource
{
	public partial class @IfcRectangleHollowProfileDef : IIfcRectangleHollowProfileDef
	{

		[CrossSchemaAttribute(typeof(IIfcRectangleHollowProfileDef), 6)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcRectangleHollowProfileDef.WallThickness 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(WallThickness);
			} 
			set
			{
				WallThickness = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRectangleHollowProfileDef), 7)]
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcRectangleHollowProfileDef.InnerFilletRadius 
		{ 
			get
			{
				if (!InnerFilletRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(InnerFilletRadius.Value);
			} 
			set
			{
				InnerFilletRadius = value.HasValue ? 
					new MeasureResource.IfcNonNegativeLengthMeasure(value.Value) :  
					 new MeasureResource.IfcNonNegativeLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRectangleHollowProfileDef), 8)]
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcRectangleHollowProfileDef.OuterFilletRadius 
		{ 
			get
			{
				if (!OuterFilletRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(OuterFilletRadius.Value);
			} 
			set
			{
				OuterFilletRadius = value.HasValue ? 
					new MeasureResource.IfcNonNegativeLengthMeasure(value.Value) :  
					 new MeasureResource.IfcNonNegativeLengthMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}