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
namespace Xbim.Ifc4x3.GeometryResource
{
	public partial class @IfcEllipse : IIfcEllipse
	{

		[CrossSchemaAttribute(typeof(IIfcEllipse), 2)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcEllipse.SemiAxis1 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(SemiAxis1);
			} 
			set
			{
				SemiAxis1 = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcEllipse), 3)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcEllipse.SemiAxis2 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(SemiAxis2);
			} 
			set
			{
				SemiAxis2 = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
	//## Custom code
	//##
	}
}